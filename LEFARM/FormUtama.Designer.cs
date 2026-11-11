namespace LEFARM
{
    partial class FormUtama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlNavbar = new FlowLayoutPanel();
            btnBeranda = new Button();
            btnDataKolam = new Button();
            btnKeuangan = new Button();
            btnJadwal = new Button();
            btnKeluar = new Button();
            pnlSubKeuangan = new FlowLayoutPanel();
            btnPemasukan = new Button();
            btnPengeluaran = new Button();
            btnPanen = new Button();
            btnLaporan = new Button();
            pnlSubJadwal = new FlowLayoutPanel();
            btnPengurasan = new Button();
            btnPakan = new Button();
            pnlIsi = new Panel();
            pnlNavbar.SuspendLayout();
            pnlSubKeuangan.SuspendLayout();
            pnlSubJadwal.SuspendLayout();
            SuspendLayout();
            // 
            // pnlNavbar
            // 
            pnlNavbar.BackColor = Color.SeaGreen;
            pnlNavbar.Controls.Add(btnBeranda);
            pnlNavbar.Controls.Add(btnDataKolam);
            pnlNavbar.Controls.Add(btnKeuangan);
            pnlNavbar.Controls.Add(btnJadwal);
            pnlNavbar.Controls.Add(btnKeluar);
            pnlNavbar.Dock = DockStyle.Top;
            pnlNavbar.Location = new Point(0, 0);
            pnlNavbar.Name = "pnlNavbar";
            pnlNavbar.Size = new Size(982, 44);
            pnlNavbar.TabIndex = 0;
            // 
            // btnBeranda
            // 
            btnBeranda.FlatStyle = FlatStyle.Flat;
            btnBeranda.ForeColor = Color.Transparent;
            btnBeranda.Location = new Point(3, 3);
            btnBeranda.Name = "btnBeranda";
            btnBeranda.Size = new Size(110, 34);
            btnBeranda.TabIndex = 0;
            btnBeranda.Text = "Beranda";
            btnBeranda.UseVisualStyleBackColor = true;
            btnBeranda.Click += btnBeranda_Click;
            // 
            // btnDataKolam
            // 
            btnDataKolam.FlatStyle = FlatStyle.Flat;
            btnDataKolam.ForeColor = Color.Transparent;
            btnDataKolam.Location = new Point(119, 3);
            btnDataKolam.Name = "btnDataKolam";
            btnDataKolam.Size = new Size(110, 34);
            btnDataKolam.TabIndex = 1;
            btnDataKolam.Text = "Data Kolam";
            btnDataKolam.UseVisualStyleBackColor = true;
            btnDataKolam.Click += btnDataKolam_Click;
            // 
            // btnKeuangan
            // 
            btnKeuangan.FlatStyle = FlatStyle.Flat;
            btnKeuangan.ForeColor = Color.Transparent;
            btnKeuangan.Location = new Point(235, 3);
            btnKeuangan.Name = "btnKeuangan";
            btnKeuangan.Size = new Size(110, 34);
            btnKeuangan.TabIndex = 2;
            btnKeuangan.Text = "Keuangan";
            btnKeuangan.UseVisualStyleBackColor = true;
            btnKeuangan.Click += btnKeuangan_Click;
            // 
            // btnJadwal
            // 
            btnJadwal.FlatStyle = FlatStyle.Flat;
            btnJadwal.ForeColor = Color.Transparent;
            btnJadwal.Location = new Point(351, 3);
            btnJadwal.Name = "btnJadwal";
            btnJadwal.Size = new Size(110, 34);
            btnJadwal.TabIndex = 3;
            btnJadwal.Text = "Jadwal";
            btnJadwal.UseVisualStyleBackColor = true;
            // 
            // btnKeluar
            // 
            btnKeluar.FlatStyle = FlatStyle.Flat;
            btnKeluar.ForeColor = Color.Transparent;
            btnKeluar.Location = new Point(467, 3);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(110, 34);
            btnKeluar.TabIndex = 4;
            btnKeluar.Text = "Keluar";
            btnKeluar.UseVisualStyleBackColor = true;
            // 
            // pnlSubKeuangan
            // 
            pnlSubKeuangan.BackColor = Color.Gainsboro;
            pnlSubKeuangan.Controls.Add(btnPemasukan);
            pnlSubKeuangan.Controls.Add(btnPengeluaran);
            pnlSubKeuangan.Controls.Add(btnPanen);
            pnlSubKeuangan.Controls.Add(btnLaporan);
            pnlSubKeuangan.Dock = DockStyle.Top;
            pnlSubKeuangan.Location = new Point(0, 44);
            pnlSubKeuangan.Name = "pnlSubKeuangan";
            pnlSubKeuangan.Size = new Size(982, 40);
            pnlSubKeuangan.TabIndex = 1;
            // 
            // btnPemasukan
            // 
            btnPemasukan.BackColor = Color.White;
            btnPemasukan.FlatStyle = FlatStyle.Flat;
            btnPemasukan.ForeColor = Color.Black;
            btnPemasukan.Location = new Point(3, 3);
            btnPemasukan.Name = "btnPemasukan";
            btnPemasukan.Size = new Size(110, 30);
            btnPemasukan.TabIndex = 0;
            btnPemasukan.Text = "Pemasukan";
            btnPemasukan.UseVisualStyleBackColor = false;
            // 
            // btnPengeluaran
            // 
            btnPengeluaran.BackColor = Color.White;
            btnPengeluaran.FlatStyle = FlatStyle.Flat;
            btnPengeluaran.ForeColor = Color.Black;
            btnPengeluaran.Location = new Point(119, 3);
            btnPengeluaran.Name = "btnPengeluaran";
            btnPengeluaran.Size = new Size(110, 30);
            btnPengeluaran.TabIndex = 1;
            btnPengeluaran.Text = "Pengeluaran";
            btnPengeluaran.UseVisualStyleBackColor = false;
            // 
            // btnPanen
            // 
            btnPanen.BackColor = Color.White;
            btnPanen.FlatStyle = FlatStyle.Flat;
            btnPanen.ForeColor = Color.Black;
            btnPanen.Location = new Point(235, 3);
            btnPanen.Name = "btnPanen";
            btnPanen.Size = new Size(110, 30);
            btnPanen.TabIndex = 2;
            btnPanen.Text = "Panen";
            btnPanen.UseVisualStyleBackColor = false;
            // 
            // btnLaporan
            // 
            btnLaporan.BackColor = Color.White;
            btnLaporan.FlatStyle = FlatStyle.Flat;
            btnLaporan.ForeColor = Color.Black;
            btnLaporan.Location = new Point(351, 3);
            btnLaporan.Name = "btnLaporan";
            btnLaporan.Size = new Size(110, 30);
            btnLaporan.TabIndex = 3;
            btnLaporan.Text = "Laporan";
            btnLaporan.UseVisualStyleBackColor = false;
            // 
            // pnlSubJadwal
            // 
            pnlSubJadwal.BackColor = Color.Gainsboro;
            pnlSubJadwal.Controls.Add(btnPengurasan);
            pnlSubJadwal.Controls.Add(btnPakan);
            pnlSubJadwal.Dock = DockStyle.Top;
            pnlSubJadwal.Location = new Point(0, 84);
            pnlSubJadwal.Name = "pnlSubJadwal";
            pnlSubJadwal.Size = new Size(982, 40);
            pnlSubJadwal.TabIndex = 2;
            // 
            // btnPengurasan
            // 
            btnPengurasan.BackColor = Color.White;
            btnPengurasan.FlatStyle = FlatStyle.Flat;
            btnPengurasan.ForeColor = Color.Black;
            btnPengurasan.Location = new Point(3, 3);
            btnPengurasan.Name = "btnPengurasan";
            btnPengurasan.Size = new Size(110, 30);
            btnPengurasan.TabIndex = 1;
            btnPengurasan.Text = "Pengurasan";
            btnPengurasan.UseVisualStyleBackColor = false;
            // 
            // btnPakan
            // 
            btnPakan.BackColor = Color.White;
            btnPakan.FlatStyle = FlatStyle.Flat;
            btnPakan.ForeColor = Color.Black;
            btnPakan.Location = new Point(119, 3);
            btnPakan.Name = "btnPakan";
            btnPakan.Size = new Size(110, 30);
            btnPakan.TabIndex = 2;
            btnPakan.Text = "Pakan";
            btnPakan.UseVisualStyleBackColor = false;
            // 
            // pnlIsi
            // 
            pnlIsi.BackColor = Color.White;
            pnlIsi.Dock = DockStyle.Fill;
            pnlIsi.Location = new Point(0, 124);
            pnlIsi.Name = "pnlIsi";
            pnlIsi.Size = new Size(982, 429);
            pnlIsi.TabIndex = 3;
            // 
            // FormUtama
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(982, 553);
            Controls.Add(pnlIsi);
            Controls.Add(pnlSubJadwal);
            Controls.Add(pnlSubKeuangan);
            Controls.Add(pnlNavbar);
            Name = "FormUtama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LEFARM";
            pnlNavbar.ResumeLayout(false);
            pnlSubKeuangan.ResumeLayout(false);
            pnlSubJadwal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel pnlNavbar;
        private FlowLayoutPanel pnlSubKeuangan;
        private Button btnBeranda;
        private FlowLayoutPanel pnlSubJadwal;
        private Panel pnlIsi;
        private Button btnDataKolam;
        private Button btnKeuangan;
        private Button btnJadwal;
        private Button btnKeluar;
        private Button btnPemasukan;
        private Button btnPengeluaran;
        private Button btnPanen;
        private Button btnLaporan;
        private Button btnPengurasan;
        private Button btnPakan;
    }
}