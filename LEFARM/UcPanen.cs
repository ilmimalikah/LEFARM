using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Npgsql;

namespace LEFARM
{
    public partial class UcPanen : UserControl
    {
        public UcPanen()
        {
            InitializeComponent();

            // Event perhitungan total harga
            txtBeratKg.TextChanged += HitungTotalHarga;
            txtHargaPerKg.TextChanged += HitungTotalHarga;

            // Event tombol
            btnTambah.Click += btnTambah_Click;
            btnUbah.Click += btnUbah_Click;
            btnHapus.Click += btnHapus_Click;
            btnBersihkan.Click += btnBersihkan_Click;

            // Event DataGridView
            dgvPanen.CellClick += dgvPanen_CellClick;

            // Memuat data
            IsiComboKolam();
            TampilkanData();
        }

        // =====================================
        // MENGISI COMBOBOX KOLAM
        // =====================================
        private void IsiComboKolam()
        {
            try
            {
                string sql = @"
                    SELECT id_kolam, nama_kolam
                    FROM kolam
                    ORDER BY id_kolam DESC";

                DataTable tabel = Koneksi.AmbilData(sql);

                cmbKolam.DataSource = null;
                cmbKolam.DisplayMember = "nama_kolam";
                cmbKolam.ValueMember = "id_kolam";
                cmbKolam.DataSource = tabel;
                cmbKolam.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data kolam: " + ex.Message);
            }
        }

        // =====================================
        // MENAMPILKAN DATA PANEN
        // =====================================
        private void TampilkanData()
        {
            try
            {
                string sql = @"
                    SELECT
                        p.id_panen,
                        p.id_kolam,
                        k.nama_kolam,
                        p.tanggal_panen,
                        p.berat_kg,
                        p.harga_per_kg,
                        p.total_harga
                    FROM panen p
                    INNER JOIN kolam k
                    ON p.id_kolam = k.id_kolam
                    ORDER BY p.id_panen DESC";

                DataTable tabel = Koneksi.AmbilData(sql);

                dgvPanen.AutoGenerateColumns = false;

                colIdPanen.DataPropertyName = "id_panen";
                colKolam.DataPropertyName = "nama_kolam";
                colTanggalPanen.DataPropertyName = "tanggal_panen";
                colBeratKg.DataPropertyName = "berat_kg";
                colHargaPerKg.DataPropertyName = "harga_per_kg";
                colTotalHarga.DataPropertyName = "total_harga";

                dgvPanen.DataSource = tabel;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data panen: " + ex.Message);
            }
        }

        // =====================================
        // MENGHITUNG TOTAL HARGA
        // =====================================
        private void HitungTotalHarga(object sender, EventArgs e)
        {
            decimal berat;
            decimal harga;

            bool beratValid = decimal.TryParse(
                txtBeratKg.Text,
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out berat
            );

            bool hargaValid = decimal.TryParse(
                txtHargaPerKg.Text,
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out harga
            );

            if (beratValid && hargaValid)
            {
                txtTotalHarga.Text =
                    (berat * harga).ToString("N2", CultureInfo.CurrentCulture);
            }
            else
            {
                txtTotalHarga.Clear();
            }
        }

        // =====================================
        // VALIDASI INPUT
        // =====================================
        private bool ValidasiInput()
        {
            if (cmbKolam.SelectedIndex == -1 ||
                cmbKolam.SelectedValue == null)
            {
                MessageBox.Show("Pilih kolam terlebih dahulu.");
                cmbKolam.Focus();
                return false;
            }

            if (!decimal.TryParse(
                txtBeratKg.Text,
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out decimal berat) || berat <= 0)
            {
                MessageBox.Show("Masukkan berat panen yang benar.");
                txtBeratKg.Focus();
                return false;
            }

            if (!decimal.TryParse(
                txtHargaPerKg.Text,
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out decimal harga) || harga <= 0)
            {
                MessageBox.Show("Masukkan harga per kg yang benar.");
                txtHargaPerKg.Focus();
                return false;
            }

            return true;
        }

        // =====================================
        // TOMBOL TAMBAH
        // =====================================
        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput())
                return;

            try
            {
                int idKolam = Convert.ToInt32(cmbKolam.SelectedValue);
                decimal berat = decimal.Parse(txtBeratKg.Text, CultureInfo.CurrentCulture);
                decimal harga = decimal.Parse(txtHargaPerKg.Text, CultureInfo.CurrentCulture);
                decimal total = berat * harga;

                string sql = @"
                    INSERT INTO panen
                    (id_kolam, tanggal_panen, berat_kg, harga_per_kg, total_harga)
                    VALUES
                    (@id_kolam, @tanggal_panen, @berat_kg, @harga_per_kg, @total_harga)";

                Koneksi.Jalankan(
                    sql,
                    new NpgsqlParameter("@id_kolam", idKolam),
                    new NpgsqlParameter("@tanggal_panen", dtpTanggalPanen.Value.Date),
                    new NpgsqlParameter("@berat_kg", berat),
                    new NpgsqlParameter("@harga_per_kg", harga),
                    new NpgsqlParameter("@total_harga", total)
                );

                MessageBox.Show("Data panen berhasil ditambahkan.");

                BersihkanInput();
                TampilkanData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan data: " + ex.Message);
            }
        }

        // =====================================
        // TOMBOL UBAH
        // =====================================
        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dgvPanen.CurrentRow == null)
            {
                MessageBox.Show("Pilih data yang ingin diubah.");
                return;
            }

            if (!ValidasiInput())
                return;

            try
            {
                int idPanen = Convert.ToInt32(
                    dgvPanen.CurrentRow.Cells["colIdPanen"].Value
                );

                int idKolam = Convert.ToInt32(cmbKolam.SelectedValue);
                decimal berat = decimal.Parse(txtBeratKg.Text, CultureInfo.CurrentCulture);
                decimal harga = decimal.Parse(txtHargaPerKg.Text, CultureInfo.CurrentCulture);
                decimal total = berat * harga;

                string sql = @"
                    UPDATE panen
                    SET
                        id_kolam = @id_kolam,
                        tanggal_panen = @tanggal_panen,
                        berat_kg = @berat_kg,
                        harga_per_kg = @harga_per_kg,
                        total_harga = @total_harga
                    WHERE id_panen = @id_panen";

                Koneksi.Jalankan(
                    sql,
                    new NpgsqlParameter("@id_kolam", idKolam),
                    new NpgsqlParameter("@tanggal_panen", dtpTanggalPanen.Value.Date),
                    new NpgsqlParameter("@berat_kg", berat),
                    new NpgsqlParameter("@harga_per_kg", harga),
                    new NpgsqlParameter("@total_harga", total),
                    new NpgsqlParameter("@id_panen", idPanen)
                );

                MessageBox.Show("Data panen berhasil diubah.");

                BersihkanInput();
                TampilkanData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah data: " + ex.Message);
            }
        }

        // =====================================
        // TOMBOL HAPUS
        // =====================================
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvPanen.CurrentRow == null)
            {
                MessageBox.Show("Pilih data yang ingin dihapus.");
                return;
            }

            DialogResult hasil = MessageBox.Show(
                "Yakin ingin menghapus data panen ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (hasil != DialogResult.Yes)
                return;

            try
            {
                int idPanen = Convert.ToInt32(
                    dgvPanen.CurrentRow.Cells["colIdPanen"].Value
                );

                string sql = @"
                    DELETE FROM panen
                    WHERE id_panen = @id_panen";

                Koneksi.Jalankan(
                    sql,
                    new NpgsqlParameter("@id_panen", idPanen)
                );

                MessageBox.Show("Data panen berhasil dihapus.");

                BersihkanInput();
                TampilkanData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus data: " + ex.Message);
            }
        }

        // =====================================
        // MEMILIH DATA DARI DATAGRIDVIEW
        // =====================================
        private void dgvPanen_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                DataGridViewRow baris = dgvPanen.Rows[e.RowIndex];

                DataRowView data = baris.DataBoundItem as DataRowView;

                if (data != null)
                {
                    cmbKolam.SelectedValue = data["id_kolam"];
                }

                dtpTanggalPanen.Value = Convert.ToDateTime(
                    baris.Cells["colTanggalPanen"].Value
                );

                txtBeratKg.Text = Convert.ToDecimal(
                    baris.Cells["colBeratKg"].Value
                ).ToString(CultureInfo.CurrentCulture);

                txtHargaPerKg.Text = Convert.ToDecimal(
                    baris.Cells["colHargaPerKg"].Value
                ).ToString(CultureInfo.CurrentCulture);

                txtTotalHarga.Text = Convert.ToDecimal(
                    baris.Cells["colTotalHarga"].Value
                ).ToString("N2", CultureInfo.CurrentCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memilih data: " + ex.Message);
            }
        }

        // =====================================
        // MEMBERSIHKAN INPUT
        // =====================================
        private void BersihkanInput()
        {
            cmbKolam.SelectedIndex = -1;
            dtpTanggalPanen.Value = DateTime.Today;

            txtBeratKg.Clear();
            txtHargaPerKg.Clear();
            txtTotalHarga.Clear();

            dgvPanen.ClearSelection();
            dgvPanen.CurrentCell = null;
        }

        // =====================================
        // TOMBOL BERSIHKAN
        // =====================================
        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            BersihkanInput();
        }

        // =====================================
        // EVENT YANG SUDAH ADA DARI KODE AWAL
        // =====================================
        

        private void lblTanggalPanen_Click(object sender, EventArgs e)
        {
        }

        private void lblDataPanen_Click(object sender, EventArgs e)
        {
        }

        private void lblTotalHarga_Click(object sender, EventArgs e)
        {
        }

        private void dgvPanen_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }
    }
}
