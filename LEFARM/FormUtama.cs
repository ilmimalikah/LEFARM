using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LEFARM
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();

            // Menghubungkan tombol dengan method di bawah
            this.Load += FormUtama_Load;
            btnBeranda.Click += btnBeranda_Click;
            btnDataKolam.Click += btnDataKolam_Click;
            btnKeuangan.Click += btnKeuangan_Click;
            btnJadwal.Click += btnJadwal_Click;
            btnKeluar.Click += btnKeluar_Click;
            btnPemasukan.Click += btnPemasukan_Click;
            btnPengeluaran.Click += btnPengeluaran_Click;
            btnPanen.Click += btnPanen_Click;
            btnLaporan.Click += btnLaporan_Click;
            btnPengurasan.Click += btnPengurasan_Click;
            btnPakan.Click += btnPakan_Click;
        }
        private void TampilkanHalaman(UserControl halaman, string judul)
        {
            pnlIsi.Controls.Clear();
            halaman.Dock = DockStyle.Fill;
            pnlIsi.Controls.Add(halaman);
            this.Text = "LEFARM - " + judul;
        }
        private void SembunyikanSubMenu()
        {
            pnlSubKeuangan.Visible = false;
            pnlSubJadwal.Visible = false;
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            SembunyikanSubMenu();
            TampilkanHalaman(new UcBeranda(), "Beranda");
        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            SembunyikanSubMenu();
            TampilkanHalaman(new UcBeranda(), "Beranda");
        }

        private void btnDataKolam_Click(object sender, EventArgs e)
        {
            SembunyikanSubMenu();
            TampilkanHalaman(new UcKolam(), "Data Kolam");
        }

        private void btnKeuangan_Click(object sender, EventArgs e)
        {
            SembunyikanSubMenu();
            pnlSubKeuangan.Visible = true;
            TampilkanHalaman(new UcPemasukan(), "Keuangan - Pemasukan");
        }

        private void btnJadwal_Click(object sender, EventArgs e)
        {
            SembunyikanSubMenu();
            pnlSubJadwal.Visible = true;
            TampilkanHalaman(new UcJadwalPengurasan(), "Jadwal Pengurasan");
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            DialogResult jawab = MessageBox.Show("Yakin ingin keluar?", "Keluar", MessageBoxButtons.YesNo);
            if (jawab == DialogResult.Yes)
            {
                this.Hide();
                FormLogin login = new FormLogin();
                if (login.ShowDialog() == DialogResult.OK)
                {
                    SembunyikanSubMenu();
                    TampilkanHalaman(new UcBeranda(), "Beranda");
                    this.Show();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void btnPemasukan_Click(object sender, EventArgs e)
        {
            TampilkanHalaman(new UcPemasukan(), "Keuangan - Pemasukan");
        }

        private void btnPengeluaran_Click(object sender, EventArgs e)
        {
            TampilkanHalaman(new UcPengeluaran(), "Keuangan - Pengeluaran");
        }

        private void btnPanen_Click(object sender, EventArgs e)
        {
            TampilkanHalaman(new UcPanen(), "Keuangan - Panen");
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            TampilkanHalaman(new UcLaporan(), "Keuangan - Laporan");
        }

        private void btnPengurasan_Click(object sender, EventArgs e)
        {
            TampilkanHalaman(new UcJadwalPengurasan(), "Jadwal Pengurasan");
        }

        private void btnPakan_Click(object sender, EventArgs e)
        {
            TampilkanHalaman(new UcJadwalPakan(), "Jadwal Pakan");
        }
    }
}
