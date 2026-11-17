using LEFARM.Model;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Data;
using System.Windows.Forms;

namespace LEFARM
{
    public partial class UcJadwalPengurasan : UserControl
    {
        public UcJadwalPengurasan()
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
                string query = "SELECT * FROM jadwal_pengurasan ORDER BY tanggal, jam";
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

        private bool ValidasiInput(out TimeSpan jam)
        {
            jam = TimeSpan.Zero;

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
            if (string.IsNullOrWhiteSpace(cbMetode.Text))
            {
                MessageBox.Show("Keterangan wajib dipilih.");
                cbMetode.Focus();
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

        private NpgsqlParameter[] BuatParameter(TimeSpan jam)
        {
            return new NpgsqlParameter[] {
                new NpgsqlParameter("@kolam", NpgsqlDbType.Varchar) { Value = txtIdKolam.Text.Trim() },
                new NpgsqlParameter("@tgl", NpgsqlDbType.Date) { Value = dtpTanggal.Value.Date },
                new NpgsqlParameter("@jam", NpgsqlDbType.Time) { Value = jam },
                new NpgsqlParameter("@metode", NpgsqlDbType.Varchar) { Value = cbMetode.Text },
                new NpgsqlParameter("@status", NpgsqlDbType.Varchar) { Value = cbStatus.Text }
            };
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput(out TimeSpan jam)) return;

            try
            {
                string query = "INSERT INTO jadwal_pengurasan (nama_kolam, tanggal, jam, metode, status) VALUES (@kolam, @tgl, @jam, @metode, @status)";

                Koneksi.Jalankan(query, BuatParameter(jam));
                MessageBox.Show("Data pengurasan berhasil disimpan!");
                TampilData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput(out TimeSpan jam)) return;

            try
            {
                string query = "UPDATE jadwal_pengurasan SET tanggal=@tgl, jam=@jam, metode=@metode, status=@status WHERE nama_kolam=@kolam";

                Koneksi.Jalankan(query, BuatParameter(jam));
                MessageBox.Show("Data pengurasan berhasil diubah!");
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
                string query = "DELETE FROM jadwal_pengurasan WHERE nama_kolam=@kolam";
                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@kolam", NpgsqlDbType.Varchar) { Value = txtIdKolam.Text.Trim() }
                };

                Koneksi.Jalankan(query, parameters);
                MessageBox.Show("Data pengurasan berhasil dihapus!");
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

            cbMetode.Text = row.Cells["metode"].Value?.ToString() ?? "";
            cbStatus.Text = row.Cells["status"].Value?.ToString() ?? "";
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            txtIdKolam.Clear();
            dtpTanggal.Value = DateTime.Now;
            txtJam.Clear();
            cbMetode.SelectedIndex = -1;
            cbStatus.Text = "Belum";

            txtIdKolam.Focus();
        }
    }
}