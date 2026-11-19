// FILE: UcKolam.cs (halaman Data Kolam)
using System;
using System.Windows.Forms;
using Npgsql;

namespace LEFARM
{
    public partial class UcKolam : UserControl
    {
        // Menyimpan id kolam yang dipilih di tabel (0 = belum ada yang dipilih)
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
            // Supaya designer tidak mencoba membuka database
            if (DesignMode)
            {
                return;
            }
            TampilkanData();
        }

        // Mengisi tabel dengan data dari database
        private void TampilkanData()
        {
            try
            {
                Kolam k = new Kolam();
                dgvKolam.DataSource = k.LihatDataKolam();

                dgvKolam.Columns["id_kolam"].HeaderText = "ID";
                dgvKolam.Columns["nama_kolam"].HeaderText = "Nama Kolam";
                dgvKolam.Columns["ukuran"].HeaderText = "Ukuran";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data: " + ex.Message);
            }
        }

        // Mengosongkan isian form
        private void BersihkanForm()
        {
            idTerpilih = 0;
            txtNamaKolam.Clear();
            txtUkuran.Clear();
            dgvKolam.ClearSelection();
        }

        // Memindahkan isian form ke objek Kolam
        private Kolam BuatKolamDariForm()
        {
            Kolam k = new Kolam();
            k.IdKolam = idTerpilih;
            k.NamaKolam = txtNamaKolam.Text;
            k.Ukuran = txtUkuran.Text;
            return k;
        }

        private void TambahData()
        {
            try
            {
                Kolam k = BuatKolamDariForm();
                k.TambahDataKolam();

                MessageBox.Show("Data berhasil ditambahkan!");
                TampilkanData();
                BersihkanForm();
            }
            catch (ArgumentException ex)
            {
                // Pesan dari kelas Kolam: "Semua kolom wajib diisi"
                MessageBox.Show(ex.Message + "!");
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
                MessageBox.Show("Pilih terlebih dahulu data yang mau diubah");
                return;
            }

            try
            {
                Kolam k = BuatKolamDariForm();
                k.UbahDataKolam();

                MessageBox.Show("Data berhasil diubah.");
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
                MessageBox.Show("Pilih terlebih dahulu data yang mau dihapus");
                return;
            }

            DialogResult jawab = MessageBox.Show("Yakin ingin menghapus data ini?", "Hapus", MessageBoxButtons.YesNo);
            if (jawab != DialogResult.Yes)
            {
                return;
            }

            try
            {
                Kolam k = BuatKolamDariForm();
                k.HapusDataKolam();

                MessageBox.Show("Data berhasil dihapus");
                TampilkanData();
                BersihkanForm();
            }
            catch (PostgresException ex) when (ex.SqlState == "23503")
            {
                // Kode 23503 = kolam masih dipakai tabel lain
                MessageBox.Show("Kolam ini tidak bisa dihapus karena masih dipakai di data lain");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        // ===== Tombol dan tabel =====
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

        // Klik baris di tabel: isi form dengan data baris itu
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
        }
    }
}