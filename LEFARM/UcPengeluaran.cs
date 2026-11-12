
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Npgsql;

namespace LEFARM
{
    public partial class UcPengeluaran : UserControl
    {
        private int idPengeluaran = 0;

        public UcPengeluaran()
        {
            InitializeComponent();

            btnTambah.Click += btnTambah_Click;
            btnUbah.Click += btnUbah_Click;
            btnHapus.Click += btnHapus_Click;
            btnBersihkan.Click += btnBersihkan_Click;
            dgvPengeluaran.CellClick += dgvPengeluaran_CellClick;
            this.Load += UcPengeluaran_Load;
        }

        private void UcPengeluaran_Load(object sender, EventArgs e)
        {
            IsiComboKolam();

            cmbKategori.Items.Clear();
            cmbKategori.Items.AddRange(new object[]
            {
                "Pakan",
                "Bibit",
                "Obat",
                "Listrik",
                "Lainnya"
            });

            if (cmbKategori.Items.Count > 0)
                cmbKategori.SelectedIndex = 0;

            TampilkanData();
        }

        private void IsiComboKolam()
        {
            try
            {
                DataTable tabel = Koneksi.AmbilData(
                    "SELECT id_kolam, nama_kolam FROM kolam ORDER BY id_kolam"
                );

                cmbKolam.DataSource = tabel;
                cmbKolam.DisplayMember = "nama_kolam";
                cmbKolam.ValueMember = "id_kolam";
                cmbKolam.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data kolam: " + ex.Message);
            }
        }

        private void TampilkanData()
        {
            try
            {
                string sql = @"
                    SELECT
                        p.id_pengeluaran AS ""ID"",
                        p.id_kolam,
                        k.nama_kolam AS ""Kolam"",
                        p.tanggal AS ""Tanggal"",
                        p.kategori AS ""Kategori"",
                        p.keterangan AS ""Keterangan"",
                        p.jumlah AS ""Jumlah (Rp)""
                    FROM pengeluaran p
                    INNER JOIN kolam k ON p.id_kolam = k.id_kolam
                    ORDER BY p.id_pengeluaran DESC
                ";

                dgvPengeluaran.DataSource = Koneksi.AmbilData(sql);

                if (dgvPengeluaran.Columns.Contains("id_kolam"))
                    dgvPengeluaran.Columns["id_kolam"].Visible = false;

                if (dgvPengeluaran.Columns.Contains("Tanggal"))
                    dgvPengeluaran.Columns["Tanggal"].DefaultCellStyle.Format = "dd/MM/yyyy";

                if (dgvPengeluaran.Columns.Contains("Jumlah (Rp)"))
                    dgvPengeluaran.Columns["Jumlah (Rp)"].DefaultCellStyle.Format = "N0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan pengeluaran: " + ex.Message);
            }
        }

        private bool ValidasiInput()
        {
            if (cmbKolam.SelectedIndex < 0 ||
                cmbKolam.SelectedValue == null ||
                cmbKolam.SelectedValue is DataRowView)
            {
                MessageBox.Show("Pilih kolam terlebih dahulu.");
                return false;
            }

            if (cmbKategori.SelectedIndex < 0)
            {
                MessageBox.Show("Pilih kategori pengeluaran.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtKeterangan.Text))
            {
                MessageBox.Show("Keterangan wajib diisi.");
                txtKeterangan.Focus();
                return false;
            }

            decimal jumlah;
            if (!decimal.TryParse(
                txtJumlah.Text,
                NumberStyles.Number,
                CultureInfo.GetCultureInfo("id-ID"),
                out jumlah) || jumlah <= 0)
            {
                MessageBox.Show("Masukkan jumlah yang valid dan lebih dari nol.");
                txtJumlah.Focus();
                return false;
            }

            return true;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput()) return;

            try
            {
                string sql = @"
                    INSERT INTO pengeluaran
                    (id_kolam, tanggal, kategori, keterangan, jumlah)
                    VALUES
                    (@id_kolam, @tanggal, @kategori, @keterangan, @jumlah)
                ";

                Koneksi.Jalankan(
                    sql,
                    new NpgsqlParameter("@id_kolam", Convert.ToInt32(cmbKolam.SelectedValue)),
                    new NpgsqlParameter("@tanggal", dtpTanggal.Value.Date),
                    new NpgsqlParameter("@kategori", cmbKategori.Text),
                    new NpgsqlParameter("@keterangan", txtKeterangan.Text.Trim()),
                    new NpgsqlParameter("@jumlah",
                        decimal.Parse(txtJumlah.Text, CultureInfo.GetCultureInfo("id-ID")))
                );

                MessageBox.Show("Data pengeluaran berhasil ditambahkan.");
                TampilkanData();
                BersihkanForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan data: " + ex.Message);
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (idPengeluaran == 0)
            {
                MessageBox.Show("Pilih data yang ingin diubah.");
                return;
            }

            if (!ValidasiInput()) return;

            try
            {
                string sql = @"
                    UPDATE pengeluaran
                    SET id_kolam = @id_kolam,
                        tanggal = @tanggal,
                        kategori = @kategori,
                        keterangan = @keterangan,
                        jumlah = @jumlah
                    WHERE id_pengeluaran = @id
                ";

                Koneksi.Jalankan(
                    sql,
                    new NpgsqlParameter("@id_kolam", Convert.ToInt32(cmbKolam.SelectedValue)),
                    new NpgsqlParameter("@tanggal", dtpTanggal.Value.Date),
                    new NpgsqlParameter("@kategori", cmbKategori.Text),
                    new NpgsqlParameter("@keterangan", txtKeterangan.Text.Trim()),
                    new NpgsqlParameter("@jumlah",
                        decimal.Parse(txtJumlah.Text, CultureInfo.GetCultureInfo("id-ID"))),
                    new NpgsqlParameter("@id", idPengeluaran)
                );

                MessageBox.Show("Data pengeluaran berhasil diubah.");
                TampilkanData();
                BersihkanForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah data: " + ex.Message);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (idPengeluaran == 0)
            {
                MessageBox.Show("Pilih data yang ingin dihapus.");
                return;
            }

            DialogResult konfirmasi = MessageBox.Show(
                "Yakin ingin menghapus data ini?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (konfirmasi != DialogResult.Yes) return;

            try
            {
                Koneksi.Jalankan(
                    "DELETE FROM pengeluaran WHERE id_pengeluaran = @id",
                    new NpgsqlParameter("@id", idPengeluaran)
                );

                MessageBox.Show("Data pengeluaran berhasil dihapus.");
                TampilkanData();
                BersihkanForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus data: " + ex.Message);
            }
        }

        private void dgvPengeluaran_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow baris = dgvPengeluaran.Rows[e.RowIndex];

            idPengeluaran = Convert.ToInt32(baris.Cells["ID"].Value);

            cmbKolam.SelectedValue = Convert.ToInt32(
                baris.Cells["id_kolam"].Value
            );

            dtpTanggal.Value = Convert.ToDateTime(
                baris.Cells["Tanggal"].Value
            );

            cmbKategori.Text = baris.Cells["Kategori"].Value.ToString();
            txtKeterangan.Text = baris.Cells["Keterangan"].Value.ToString();
            txtJumlah.Text = Convert.ToDecimal(
                baris.Cells["Jumlah (Rp)"].Value
            ).ToString("0.##", CultureInfo.GetCultureInfo("id-ID"));
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            BersihkanForm();
        }

        private void BersihkanForm()
        {
            idPengeluaran = 0;

            cmbKolam.SelectedIndex = -1;
            cmbKategori.SelectedIndex = -1;
            dtpTanggal.Value = DateTime.Today;

            txtKeterangan.Clear();
            txtJumlah.Clear();

            dgvPengeluaran.ClearSelection();
        }
    }
}
