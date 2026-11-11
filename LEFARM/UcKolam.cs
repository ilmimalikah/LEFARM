using LEFARM.Model;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Data;
using System.Windows.Forms;

namespace LEFARM
{
    public partial class UcKolam : UserControl
    {
        private int idTerpilih = 0;

        public UcKolam()
        {
            InitializeComponent();

            this.Load += UcKolam_Load;
            btnTambah.Click += btnTambah_Click;
            btnUbah.Click += btnUbah_Click;
            btnHapus.Click += btnHapus_Click;
            btnBersihkan.Click += btnBersihkan_Click;
            dgvKolam.CellClick += dgvKolam_CellClick;
        }

        private void UcKolam_Load(object sender, EventArgs e)
        {
            if (DesignMode)
            {
                return;
            }
            TampilkanData();
        }

        private void TampilkanData()
        {
            try
            {
                dgvKolam.DataSource = Koneksi.AmbilData(
                    "SELECT id_kolam, nama_kolam, ukuran, jumlah_bibit, tanggal_tebar " +
                    "FROM kolam ORDER BY id_kolam");

                dgvKolam.Columns["id_kolam"].HeaderText = "ID";
                dgvKolam.Columns["nama_kolam"].HeaderText = "Nama Kolam";
                dgvKolam.Columns["ukuran"].HeaderText = "Ukuran";
                dgvKolam.Columns["jumlah_bibit"].HeaderText = "Jumlah Bibit";
                dgvKolam.Columns["tanggal_tebar"].HeaderText = "Tanggal Tebar";
                dgvKolam.Columns["tanggal_tebar"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data: " + ex.Message);
            }
        }

        private void BersihkanForm()
        {
            idTerpilih = 0;
            txtNamaKolam.Clear();
            txtUkuran.Clear();
            nudJumlahBibit.Value = 0;
            dtpTanggalTebar.Value = DateTime.Today;
            dgvKolam.ClearSelection();
        }

        private Kolam BuatKolamDariForm()
        {
            Kolam k = new Kolam();
            k.IdKolam = idTerpilih;
            k.NamaKolam = txtNamaKolam.Text;
            k.Ukuran = txtUkuran.Text;
            k.JumlahBibit = (int)nudJumlahBibit.Value;
            k.TanggalTebar = dtpTanggalTebar.Value.Date;
            return k;
        }

        private void TambahData()
        {
            try
            {
                Kolam k = BuatKolamDariForm();
                Koneksi.Jalankan(
                    "INSERT INTO kolam (nama_kolam, ukuran, jumlah_bibit, tanggal_tebar) " +
                    "VALUES (@nama, @ukuran, @bibit, @tanggal)",
                    new NpgsqlParameter("@nama", k.NamaKolam),
                    new NpgsqlParameter("@ukuran", k.Ukuran),
                    new NpgsqlParameter("@bibit", k.JumlahBibit),
                    new NpgsqlParameter("@tanggal", NpgsqlDbType.Date) { Value = k.TanggalTebar });

                MessageBox.Show("Data berhasil ditambahkan");
                TampilkanData();
                BersihkanForm();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void UbahData()
        {
            if (idTerpilih == 0)
            {
                MessageBox.Show("Pilih dulu data yang mau diubah di tabel");
                return;
            }

            try
            {
                Kolam k = BuatKolamDariForm();
                Koneksi.Jalankan(
                    "UPDATE kolam SET nama_kolam = @nama, ukuran = @ukuran, " +
                    "jumlah_bibit = @bibit, tanggal_tebar = @tanggal WHERE id_kolam = @id",
                    new NpgsqlParameter("@nama", k.NamaKolam),
                    new NpgsqlParameter("@ukuran", k.Ukuran),
                    new NpgsqlParameter("@bibit", k.JumlahBibit),
                    new NpgsqlParameter("@tanggal", NpgsqlDbType.Date) { Value = k.TanggalTebar },
                    new NpgsqlParameter("@id", k.IdKolam));

                MessageBox.Show("Data berhasil diubah");
                TampilkanData();
                BersihkanForm();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void HapusData()
        {
            if (idTerpilih == 0)
            {
                MessageBox.Show("Pilih dulu data yang mau dihapus di tabel");
                return;
            }

            DialogResult jawab = MessageBox.Show("Yakin ingin menghapus data ini?", "Hapus", MessageBoxButtons.YesNo);
            if (jawab != DialogResult.Yes)
            {
                return;
            }

            try
            {
                Koneksi.Jalankan("DELETE FROM kolam WHERE id_kolam = @id",
                    new NpgsqlParameter("@id", idTerpilih));

                MessageBox.Show("Data berhasil dihapus");
                TampilkanData();
                BersihkanForm();
            }
            catch (PostgresException ex) when (ex.SqlState == "23503")
            {
                MessageBox.Show("Kolam ini tidak bisa dihapus karena masih dipakai di data lain");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            TambahData();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            UbahData();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            HapusData();
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            BersihkanForm();
        }

        private void dgvKolam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow baris = dgvKolam.Rows[e.RowIndex];
            idTerpilih = Convert.ToInt32(baris.Cells["id_kolam"].Value);
            txtNamaKolam.Text = Convert.ToString(baris.Cells["nama_kolam"].Value);
            txtUkuran.Text = Convert.ToString(baris.Cells["ukuran"].Value);
            nudJumlahBibit.Value = Convert.ToDecimal(baris.Cells["jumlah_bibit"].Value);
            dtpTanggalTebar.Value = DateOnly.Parse(baris.Cells["tanggal_tebar"].Value.ToString()).ToDateTime(TimeOnly.MinValue);
        }
    }
}