using Npgsql;
using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Text;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace LEFARM
{
    public partial class UcLaporan : UserControl
    {
        private PrintDocument dokumenCetak = new PrintDocument();
        private int barisCetak = 0;

        private decimal totalPemasukan = 0;
        private decimal totalPengeluaran = 0;

        public UcLaporan()
        {
            InitializeComponent();

            this.Load += UcLaporan_Load;

            btnTampilkan.Click += btnTampilkan_Click;
            btnCetak.Click += btnCetak_Click;
            btnEksporExcel.Click += btnEksporExcel_Click;

            dokumenCetak.PrintPage += dokumenCetak_PrintPage;
        }

        // =========================================
        // 1. EVENT LABEL
        // =========================================

        private void lblJudulPemasukan_Click(object sender, EventArgs e)
        {
        }

        private void lblNominalPemasukan_Click(object sender, EventArgs e)
        {
        }

        // =========================================
        // 2. PERSIAPAN TAMPILAN
        // =========================================

        private void UcLaporan_Load(object sender, EventArgs e)
        {
            // Supaya designer tidak mencoba membuka database
            if (DesignMode)
            {
                return;
            }

            try
            {
                AturBulan();
                AturKolam();

                dgvLaporan.Rows.Clear();

                totalPemasukan = 0;
                totalPengeluaran = 0;

                lblNominalPemasukan.Text = FormatRupiah(0);
                lblNominalPengeluaran.Text = FormatRupiah(0);
                lblNominalLabaRugi.Text = FormatRupiah(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat laporan: " + ex.Message,
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================
        // 3. MENGATUR PILIHAN BULAN
        // =========================================

        private void AturBulan()
        {
            cmbBulan.Items.Clear();

            for (int i = 1; i <= 12; i++)
            {
                string namaBulan =
                    CultureInfo.GetCultureInfo("id-ID")
                    .DateTimeFormat.GetMonthName(i);

                cmbBulan.Items.Add(
                    CultureInfo.GetCultureInfo("id-ID")
                    .TextInfo.ToTitleCase(namaBulan)
                );
            }

            cmbBulan.SelectedIndex = DateTime.Now.Month - 1;
        }

        // =========================================
        // 4. MENGAMBIL DATA KOLAM
        // =========================================

        private void AturKolam()
        {
            string sql = @"
                SELECT id_kolam, nama_kolam
                FROM kolam
                ORDER BY id_kolam";

            DataTable data = Koneksi.AmbilData(sql);

            cmbKolam.Items.Clear();

            cmbKolam.Items.Add(new PilihanKolam
            {
                Id = 0,
                Nama = "Semua Kolam"
            });

            foreach (DataRow row in data.Rows)
            {
                cmbKolam.Items.Add(new PilihanKolam
                {
                    Id = Convert.ToInt32(row["id_kolam"]),
                    Nama = row["nama_kolam"].ToString()
                });
            }

            cmbKolam.DisplayMember = "Nama";
            cmbKolam.SelectedIndex = 0;
        }

        // =========================================
        // 5. TOMBOL TAMPILKAN
        // =========================================

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            TampilkanLaporan();
        }

        private void TampilkanLaporan()
        {
            if (cmbBulan.SelectedIndex < 0 ||
                cmbKolam.SelectedItem == null)
            {
                MessageBox.Show("Silakan pilih bulan dan kolam.");
                return;
            }

            int bulan = cmbBulan.SelectedIndex + 1;
            int tahun = DateTime.Now.Year;

            int idKolam =
                ((PilihanKolam)cmbKolam.SelectedItem).Id;

            try
            {
                HitungTotalPemasukan(bulan, tahun, idKolam);
                HitungTotalPengeluaran(bulan, tahun, idKolam);
                HitungLabaRugi();

                TampilkanDataGridView(bulan, tahun, idKolam);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menampilkan laporan: " + ex.Message,
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================
        // 6. MENGHITUNG TOTAL PEMASUKAN
        // =========================================

        private void HitungTotalPemasukan(
            int bulan, int tahun, int idKolam)
        {
            string sql = @"
                SELECT
                    COALESCE(
                        (SELECT SUM(jumlah)
                         FROM pemasukan
                         WHERE EXTRACT(MONTH FROM tanggal) = @bulan
                         AND EXTRACT(YEAR FROM tanggal) = @tahun
                         AND (@kolam = 0 OR id_kolam = @kolam)),
                        0
                    )
                    +
                    COALESCE(
                        (SELECT SUM(total_harga)
                         FROM panen
                         WHERE EXTRACT(MONTH FROM tanggal_panen) = @bulan
                         AND EXTRACT(YEAR FROM tanggal_panen) = @tahun
                         AND (@kolam = 0 OR id_kolam = @kolam)),
                        0
                    )";

            using (NpgsqlConnection conn = Koneksi.BuatKoneksi())
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@bulan", bulan);
                    cmd.Parameters.AddWithValue("@tahun", tahun);
                    cmd.Parameters.AddWithValue("@kolam", idKolam);

                    totalPemasukan =
                        Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }

            lblNominalPemasukan.Text =
                FormatRupiah(totalPemasukan);
        }

        // =========================================
        // 7. MENGHITUNG TOTAL PENGELUARAN
        // =========================================

        private void HitungTotalPengeluaran(
            int bulan, int tahun, int idKolam)
        {
            string sql = @"
                SELECT COALESCE(SUM(jumlah), 0)
                FROM pengeluaran
                WHERE EXTRACT(MONTH FROM tanggal) = @bulan
                AND EXTRACT(YEAR FROM tanggal) = @tahun
                AND (@kolam = 0 OR id_kolam = @kolam)";

            using (NpgsqlConnection conn = Koneksi.BuatKoneksi())
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@bulan", bulan);
                    cmd.Parameters.AddWithValue("@tahun", tahun);
                    cmd.Parameters.AddWithValue("@kolam", idKolam);

                    totalPengeluaran =
                        Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }

            lblNominalPengeluaran.Text =
                FormatRupiah(totalPengeluaran);
        }

        // =========================================
        // 8. MENGHITUNG LABA / RUGI
        // =========================================

        private void HitungLabaRugi()
        {
            decimal hasil =
                totalPemasukan - totalPengeluaran;

            lblNominalLabaRugi.Text =
                FormatRupiah(hasil);
        }

        // =========================================
        // 9. FORMAT RUPIAH
        // =========================================

        private string FormatRupiah(decimal angka)
        {
            return "Rp " + angka.ToString(
                "N0",
                CultureInfo.GetCultureInfo("id-ID")
            );
        }

        // =========================================
        // 10. MENAMPILKAN DATA TRANSAKSI
        // =========================================

        private void TampilkanDataGridView(
            int bulan, int tahun, int idKolam)
        {
            string sql = @"
                SELECT
                    tanggal AS tanggal_transaksi,
                    'Pemasukan' AS jenis,
                    COALESCE(keterangan, '-') AS keterangan,
                    jumlah
                FROM pemasukan
                WHERE EXTRACT(MONTH FROM tanggal) = @bulan
                AND EXTRACT(YEAR FROM tanggal) = @tahun
                AND (@kolam = 0 OR id_kolam = @kolam)

                UNION ALL

                SELECT
                    tanggal_panen AS tanggal_transaksi,
                    'Panen' AS jenis,
                    'Hasil panen ' || berat_kg || ' kg' AS keterangan,
                    total_harga AS jumlah
                FROM panen
                WHERE EXTRACT(MONTH FROM tanggal_panen) = @bulan
                AND EXTRACT(YEAR FROM tanggal_panen) = @tahun
                AND (@kolam = 0 OR id_kolam = @kolam)

                UNION ALL

                SELECT
                    tanggal AS tanggal_transaksi,
                    'Pengeluaran' AS jenis,
                    COALESCE(kategori, '-') || ' - ' ||
                    COALESCE(keterangan, '-') AS keterangan,
                    jumlah
                FROM pengeluaran
                WHERE EXTRACT(MONTH FROM tanggal) = @bulan
                AND EXTRACT(YEAR FROM tanggal) = @tahun
                AND (@kolam = 0 OR id_kolam = @kolam)

                ORDER BY tanggal_transaksi";

            dgvLaporan.Rows.Clear();

            using (NpgsqlConnection conn = Koneksi.BuatKoneksi())
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@bulan", bulan);
                    cmd.Parameters.AddWithValue("@tahun", tahun);
                    cmd.Parameters.AddWithValue("@kolam", idKolam);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvLaporan.Rows.Add(
                                Convert.ToDateTime(
                                    reader["tanggal_transaksi"]
                                ).ToString("dd/MM/yyyy"),

                                reader["jenis"].ToString(),

                                reader["keterangan"].ToString(),

                                FormatRupiah(
                                    Convert.ToDecimal(reader["jumlah"])
                                )
                            );
                        }
                    }
                }
            }
        }

        // =========================================
        // 11. TOMBOL CETAK
        // =========================================

        private void btnCetak_Click(object sender, EventArgs e)
        {
            if (dgvLaporan.Rows.Count == 0)
            {
                MessageBox.Show("Belum ada data laporan untuk dicetak.");
                return;
            }

            barisCetak = 0;

            using (PrintPreviewDialog preview = new PrintPreviewDialog())
            {
                preview.Document = dokumenCetak;
                preview.WindowState = FormWindowState.Maximized;
                preview.ShowDialog();
            }
        }

        // =========================================
        // 12. PROSES CETAK LAPORAN
        // =========================================

        private void dokumenCetak_PrintPage(
            object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            using (Font fontJudul = new Font("Arial", 14, FontStyle.Bold))
            using (Font fontIsi = new Font("Arial", 9))
            {
                float posisiY = 40;

                if (barisCetak == 0)
                {
                    g.DrawString(
                        "LAPORAN KEUANGAN LEFARM",
                        fontJudul,
                        Brushes.Black,
                        40,
                        posisiY
                    );

                    posisiY += 35;

                    g.DrawString(
                        "Total Pemasukan: " + lblNominalPemasukan.Text,
                        fontIsi,
                        Brushes.Black,
                        40,
                        posisiY
                    );

                    posisiY += 20;

                    g.DrawString(
                        "Total Pengeluaran: " + lblNominalPengeluaran.Text,
                        fontIsi,
                        Brushes.Black,
                        40,
                        posisiY
                    );

                    posisiY += 20;

                    g.DrawString(
                        "Laba / Rugi: " + lblNominalLabaRugi.Text,
                        fontIsi,
                        Brushes.Black,
                        40,
                        posisiY
                    );

                    posisiY += 35;
                }

                while (barisCetak < dgvLaporan.Rows.Count)
                {
                    DataGridViewRow row =
                        dgvLaporan.Rows[barisCetak];

                    string isi =
                        row.Cells[0].Value + " | " +
                        row.Cells[1].Value + " | " +
                        row.Cells[2].Value + " | " +
                        row.Cells[3].Value;

                    g.DrawString(
                        isi,
                        fontIsi,
                        Brushes.Black,
                        40,
                        posisiY
                    );

                    posisiY += 22;
                    barisCetak++;

                    if (posisiY > e.MarginBounds.Bottom)
                    {
                        e.HasMorePages = true;
                        return;
                    }
                }
            }

            barisCetak = 0;
            e.HasMorePages = false;
        }

        // =========================================
        // 13. TOMBOL EKSPOR EXCEL
        // =========================================

        private void btnEksporExcel_Click(object sender, EventArgs e)
        {
            if (dgvLaporan.Rows.Count == 0)
            {
                MessageBox.Show("Belum ada data untuk diekspor.");
                return;
            }

            using (SaveFileDialog simpan = new SaveFileDialog())
            {
                simpan.Filter = "File Excel CSV (*.csv)|*.csv";
                simpan.FileName = "Laporan_Keuangan.csv";

                if (simpan.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder isi = new StringBuilder();

                    isi.AppendLine(
                        "Tanggal,Jenis,Keterangan,Jumlah (Rp)"
                    );

                    foreach (DataGridViewRow row in dgvLaporan.Rows)
                    {
                        if (row.IsNewRow)
                            continue;

                        isi.AppendLine(
                            CSV(row.Cells[0].Value) + "," +
                            CSV(row.Cells[1].Value) + "," +
                            CSV(row.Cells[2].Value) + "," +
                            CSV(row.Cells[3].Value)
                        );
                    }

                    File.WriteAllText(
                        simpan.FileName,
                        isi.ToString(),
                        new UTF8Encoding(true)
                    );

                    MessageBox.Show(
                        "Laporan berhasil diekspor.",
                        "Berhasil",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
        }

        // =========================================
        // 14. FORMAT DATA CSV
        // =========================================

        private string CSV(object nilai)
        {
            string teks = nilai?.ToString() ?? "";

            return "\"" + teks.Replace("\"", "\"\"") + "\"";
        }

        // =========================================
        // 15. PILIHAN DATA KOLAM
        // =========================================

        private class PilihanKolam
        {
            public int Id { get; set; }

            public string Nama { get; set; }

            public override string ToString()
            {
                return Nama;
            }
        }
    }
}