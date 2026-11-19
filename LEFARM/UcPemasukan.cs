
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Npgsql;
using LEFARM.Model;

namespace LEFARM
{
    public partial class UcPemasukan : UserControl
    {
        private int idPemasukan = 0;

        public UcPemasukan()
        {
            InitializeComponent();

            btnTambah.Click += (s, e) => TambahData();
            btnUbah.Click += (s, e) => UbahData();
            btnHapus.Click += (s, e) => HapusData();
            btnBersihkan.Click += (s, e) => BersihkanForm();

            dgvPemasukan.CellClick += dgvPemasukan_CellClick;

            this.Load += UcPemasukan_Load;
        }

        private void UcPemasukan_Load(object sender, EventArgs e)
        {
            IsiComboKolam();
            TampilkanData();
            BersihkanForm();
        }

        private void IsiComboKolam()
        {
            try
            {
                string sql = "SELECT id_kolam, nama_kolam FROM kolam ORDER BY id_kolam";

                DataTable tabel = Koneksi.AmbilData(sql);

                cmbKolam.DataSource = tabel;
                cmbKolam.DisplayMember = "nama_kolam";
                cmbKolam.ValueMember = "id_kolam";
                cmbKolam.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data kolam: " + ex.Message);
            }
        }

        private void TampilkanData()
        {
            try
            {
                string sql = @"
                    SELECT
                        p.id_pemasukan AS ""ID"",
                        p.id_kolam,
                        k.nama_kolam AS ""Kolam"",
                        p.tanggal AS ""Tanggal"",
                        p.keterangan AS ""Keterangan"",
                        p.jumlah AS ""Jumlah (Rp)""
                    FROM pemasukan p
                    INNER JOIN kolam k
                        ON p.id_kolam = k.id_kolam
                    ORDER BY p.id_pemasukan";

                DataTable tabel = Koneksi.AmbilData(sql);

                dgvPemasukan.DataSource = tabel;

                if (dgvPemasukan.Columns.Contains("id_kolam"))
                    dgvPemasukan.Columns["id_kolam"].Visible = false;

                dgvPemasukan.Columns["Tanggal"]
                    .DefaultCellStyle.Format = "dd/MM/yyyy";

                dgvPemasukan.Columns["Jumlah (Rp)"]
                    .DefaultCellStyle.Format = "N0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data: " + ex.Message);
            }
        }

        private bool ValidasiInput(out int idKolam, out decimal jumlah)
        {
            idKolam = 0;
            jumlah = 0;

            if (cmbKolam.SelectedIndex < 0 ||
                cmbKolam.SelectedValue == null ||
                cmbKolam.SelectedValue is DataRowView ||
                !int.TryParse(
                    cmbKolam.SelectedValue.ToString(),
                    out idKolam))
            {
                MessageBox.Show("Silakan pilih kolam terlebih dahulu.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtKeterangan.Text))
            {
                MessageBox.Show("Keterangan wajib diisi.");
                txtKeterangan.Focus();
                return false;
            }

            if (!decimal.TryParse(
                txtJumlah.Text,
                NumberStyles.Number,
                CultureInfo.GetCultureInfo("id-ID"),
                out jumlah) || jumlah <= 0)
            {
                MessageBox.Show("Jumlah pemasukan tidak valid.");
                txtJumlah.Focus();
                return false;
            }

            return true;
        }

        private void TambahData()
        {
            if (!ValidasiInput(out int idKolam, out decimal jumlah))
                return;

            try
            {
                Transaksi transaksi = new Pemasukan(
                    idKolam,
                    dtpTanggal.Value.Date,
                    txtKeterangan.Text.Trim(),
                    jumlah
                );

                string sql = @"
                    INSERT INTO pemasukan
                    (id_kolam, tanggal, keterangan, jumlah)
                    VALUES
                    (@id_kolam, @tanggal, @keterangan, @jumlah)";

                Koneksi.Jalankan(
                    sql,
                    new NpgsqlParameter("@id_kolam", transaksi.IdKolam),
                    new NpgsqlParameter("@tanggal", transaksi.Tanggal),
                    new NpgsqlParameter("@keterangan", transaksi.Keterangan),
                    new NpgsqlParameter("@jumlah", transaksi.HitungNilai())
                );

                MessageBox.Show(
                    transaksi.AmbilJenis() + " berhasil ditambahkan."
                );

                TampilkanData();
                BersihkanForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan data: " + ex.Message);
            }
        }

        private void UbahData()
        {
            if (idPemasukan == 0)
            {
                MessageBox.Show("Pilih data yang ingin diubah.");
                return;
            }

            if (!ValidasiInput(out int idKolam, out decimal jumlah))
                return;

            try
            {
                Transaksi transaksi = new Pemasukan(
                    idKolam,
                    dtpTanggal.Value.Date,
                    txtKeterangan.Text.Trim(),
                    jumlah
                );

                string sql = @"
                    UPDATE pemasukan
                    SET id_kolam = @id_kolam,
                        tanggal = @tanggal,
                        keterangan = @keterangan,
                        jumlah = @jumlah
                    WHERE id_pemasukan = @id";

                Koneksi.Jalankan(
                    sql,
                    new NpgsqlParameter("@id_kolam", transaksi.IdKolam),
                    new NpgsqlParameter("@tanggal", transaksi.Tanggal),
                    new NpgsqlParameter("@keterangan", transaksi.Keterangan),
                    new NpgsqlParameter("@jumlah", transaksi.HitungNilai()),
                    new NpgsqlParameter("@id", idPemasukan)
                );

                MessageBox.Show(
                    transaksi.AmbilJenis() + " berhasil diubah."
                );

                TampilkanData();
                BersihkanForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah data: " + ex.Message);
            }
        }

        private void HapusData()
        {
            if (idPemasukan == 0)
            {
                MessageBox.Show("Pilih data yang ingin dihapus.");
                return;
            }

            DialogResult hasil = MessageBox.Show(
                "Yakin ingin menghapus data ini?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (hasil != DialogResult.Yes)
                return;

            try
            {
                string sql = @"
                    DELETE FROM pemasukan
                    WHERE id_pemasukan = @id";

                Koneksi.Jalankan(
                    sql,
                    new NpgsqlParameter("@id", idPemasukan)
                );

                MessageBox.Show("Data pemasukan berhasil dihapus.");

                TampilkanData();
                BersihkanForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus data: " + ex.Message);
            }
        }

        private void dgvPemasukan_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow baris = dgvPemasukan.Rows[e.RowIndex];

            idPemasukan = Convert.ToInt32(baris.Cells["ID"].Value);

            cmbKolam.SelectedValue =
                Convert.ToInt32(baris.Cells["id_kolam"].Value);

            dtpTanggal.Value =
                Convert.ToDateTime(baris.Cells["Tanggal"].Value);

            txtKeterangan.Text =
                baris.Cells["Keterangan"].Value.ToString();

            txtJumlah.Text =
                Convert.ToDecimal(baris.Cells["Jumlah (Rp)"].Value)
                .ToString("N2", CultureInfo.GetCultureInfo("id-ID"));
        }

        private void BersihkanForm()
        {
            idPemasukan = 0;

            cmbKolam.SelectedIndex = -1;
            dtpTanggal.Value = DateTime.Today;
            txtKeterangan.Clear();
            txtJumlah.Clear();

            dgvPemasukan.ClearSelection();
        }
    }
}
