using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace LEFARM
{
    public partial class UcBeranda : UserControl
    {
        private CultureInfo idr = new CultureInfo("id-ID");

        public UcBeranda()
        {
            InitializeComponent();
            this.Load += UcBeranda_Load;
        }

        private void UcBeranda_Load(object sender, EventArgs e)
        {
            if (DesignMode)
            {
                return;
            }
            TampilkanRingkasan();
            TampilkanJadwal();
        }

        private decimal AmbilTotal(string sql)
        {
            DataTable tabel = Koneksi.AmbilData(sql);
            return Convert.ToDecimal(tabel.Rows[0][0]);
        }

        private string FormatRupiah(decimal angka)
        {
            return "Rp " + angka.ToString("N0", idr);
        }

        private void TampilkanRingkasan()
        {
            try
            {
                decimal pemasukan = AmbilTotal("SELECT COALESCE(SUM(jumlah), 0) FROM pemasukan");
                decimal hasilPanen = AmbilTotal("SELECT COALESCE(SUM(total_harga), 0) FROM panen");
                decimal pengeluaran = AmbilTotal("SELECT COALESCE(SUM(jumlah), 0) FROM pengeluaran");
                decimal beratPanen = AmbilTotal("SELECT COALESCE(SUM(berat_kg), 0) FROM panen");

                decimal totalPemasukan = pemasukan + hasilPanen;

                lblTotalPemasukan.Text = FormatRupiah(totalPemasukan);
                lblTotalPengeluaran.Text = FormatRupiah(pengeluaran);
                lblLabaBersih.Text = FormatRupiah(totalPemasukan - pengeluaran);
                lblTotalPanen.Text = beratPanen.ToString("N0", idr) + " kg";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data: " + ex.Message);
            }
        }

        private void TampilkanJadwal()
        {
            try
            {
                string sql =
                    "SELECT j.tanggal, 'Pengurasan' AS jenis, k.nama_kolam, j.keterangan " +
                    "FROM jadwal_pengurasan j JOIN kolam k ON k.id_kolam = j.id_kolam " +
                    "WHERE j.status = 'Belum' " +
                    "UNION ALL " +
                    "SELECT j.tanggal, 'Pakan', k.nama_kolam, j.jenis_pakan " +
                    "FROM jadwal_pakan j JOIN kolam k ON k.id_kolam = j.id_kolam " +
                    "WHERE j.status = 'Belum' " +
                    "ORDER BY tanggal LIMIT 5";

                dgvJadwal.DataSource = Koneksi.AmbilData(sql);

                dgvJadwal.Columns["tanggal"].HeaderText = "Tanggal";
                dgvJadwal.Columns["jenis"].HeaderText = "Jenis";
                dgvJadwal.Columns["nama_kolam"].HeaderText = "Kolam";
                dgvJadwal.Columns["keterangan"].HeaderText = "Keterangan";
                dgvJadwal.Columns["tanggal"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data jadwal: " + ex.Message);
            }
        }
    }
}