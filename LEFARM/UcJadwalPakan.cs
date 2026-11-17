using LEFARM.Model;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Data;
using System.Windows.Forms;

namespace LEFARM
{
    public partial class UcJadwalPakan : UserControl
    {
        public UcJadwalPakan()
        {
            InitializeComponent();

            dtpTanggal.Format = DateTimePickerFormat.Custom;
            dtpTanggal.CustomFormat = "dd-MM-yyyy";

            cbStatus.Text = "Belum";

            TampilData();
        }

        private void TampilData()
        {
            try
            {
                string query = "SELECT * FROM jadwal_pakan ORDER BY tanggal, jam";
                DataTable dt = Koneksi.AmbilData(query);
                dataGridView1.DataSource = dt;

                if (dataGridView1.Columns.Contains("tanggal"))
                    dataGridView1.Columns["tanggal"].DefaultCellStyle.Format = "dd-MM-yyyy";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        private bool ValidasiInput(out TimeSpan jam, out int gram)
        {
            jam = TimeSpan.Zero;
            gram = 0;

            if (string.IsNullOrWhiteSpace(txtIdKolam.Text))
            {
                MessageBox.Show("Nama kolam wajib diisi.");
                txtIdKolam.Focus();
                return false;
            }
            if (!TimeSpan.TryParse(txtJam.Text, out jam))
            {
                MessageBox.Show("Format jam salah. Contoh: 08:00");
                txtJam.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtJenisPakan.Text))
            {
                MessageBox.Show("Jenis pakan wajib diisi.");
                txtJenisPakan.Focus();
                return false;
            }
            if (!int.TryParse(txtJumlahGram.Text, out gram) || gram <= 0)
            {
                MessageBox.Show("Jumlah gram harus berupa angka lebih dari 0.");
                txtJumlahGram.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbStatus.Text))
            {
                MessageBox.Show("Status wajib dipilih.");
                cbStatus.Focus();
                return false;
            }
            return true;
        }

        private NpgsqlParameter[] BuatParameter(TimeSpan jam, int gram)
        {
            return new NpgsqlParameter[] {
                new NpgsqlParameter("@kolam", NpgsqlDbType.Varchar) { Value = txtIdKolam.Text.Trim() },
                new NpgsqlParameter("@tgl", NpgsqlDbType.Date) { Value = dtpTanggal.Value.Date },
                new NpgsqlParameter("@jam", NpgsqlDbType.Time) { Value = jam },
                new NpgsqlParameter("@pakan", NpgsqlDbType.Varchar) { Value = txtJenisPakan.Text.Trim() },
                new NpgsqlParameter("@gram", NpgsqlDbType.Integer) { Value = gram },
                new NpgsqlParameter("@status", NpgsqlDbType.Varchar) { Value = cbStatus.Text }
            };
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput(out TimeSpan jam, out int gram)) return;

            try
            {
                string query = "INSERT INTO jadwal_pakan (nama_kolam, tanggal, jam, jenis_pakan, jumlah_gram, status) VALUES (@kolam, @tgl, @jam, @pakan, @gram, @status)";

                Koneksi.Jalankan(query, BuatParameter(jam, gram));
                MessageBox.Show("Data berhasil disimpan!");
                TampilData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput(out TimeSpan jam, out int gram)) return;

            try
            {
                string query = "UPDATE jadwal_pakan SET tanggal=@tgl, jam=@jam, jenis_pakan=@pakan, jumlah_gram=@gram, status=@status WHERE nama_kolam=@kolam";

                Koneksi.Jalankan(query, BuatParameter(jam, gram));
                MessageBox.Show("Data berhasil diubah!");
                TampilData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdKolam.Text))
            {
                MessageBox.Show("Pilih data dulu dari tabel atau isi nama kolam.");
                return;
            }

            DialogResult konfirmasi = MessageBox.Show(
                "Yakin ingin menghapus data ini?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (konfirmasi != DialogResult.Yes) return;

            try
            {
                string query = "DELETE FROM jadwal_pakan WHERE nama_kolam=@kolam";
                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@kolam", NpgsqlDbType.Varchar) { Value = txtIdKolam.Text.Trim() }
                };

                Koneksi.Jalankan(query, parameters);
                MessageBox.Show("Data berhasil dihapus!");
                TampilData();
                btnBersihkan_Click(null, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            txtIdKolam.Text = row.Cells["nama_kolam"].Value?.ToString() ?? "";

            if (row.Cells["tanggal"].Value != null &&
                DateTime.TryParse(row.Cells["tanggal"].Value.ToString(), out DateTime tgl))
            {
                dtpTanggal.Value = tgl;
            }

            object jamValue = row.Cells["jam"].Value;
            if (jamValue != null && TimeSpan.TryParse(jamValue.ToString(), out TimeSpan jam))
                txtJam.Text = jam.ToString(@"hh\:mm");
            else
                txtJam.Text = "";

            txtJenisPakan.Text = row.Cells["jenis_pakan"].Value?.ToString() ?? "";
            txtJumlahGram.Text = row.Cells["jumlah_gram"].Value?.ToString() ?? "";
            cbStatus.Text = row.Cells["status"].Value?.ToString() ?? "";
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            txtIdKolam.Clear();
            dtpTanggal.Value = DateTime.Now;
            txtJam.Clear();
            txtJenisPakan.Clear();
            txtJumlahGram.Clear();
            cbStatus.Text = "Belum";

            txtIdKolam.Focus();
        }
    }
}