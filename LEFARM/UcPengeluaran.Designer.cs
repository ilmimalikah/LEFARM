namespace LEFARM
{
    partial class UcPengeluaran
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
            cmbKolam = new ComboBox();
            dtpTanggal = new DateTimePicker();
            cmbKategori = new ComboBox();
            txtKeterangan = new TextBox();
            lblKolam = new Label();
            lblTanggal = new Label();
            lblKategori = new Label();
            lblKeterangan = new Label();
            lblJumlah = new Label();
            txtJumlah = new TextBox();
            btnTambah = new Button();
            btnUbah = new Button();
            btnHapus = new Button();
            btnBersihkan = new Button();
            dgvPengeluaran = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPengeluaran).BeginInit();
            SuspendLayout();
            // 
            // cmbKolam
            // 
            cmbKolam.FormattingEnabled = true;
            cmbKolam.Location = new Point(15, 102);
            cmbKolam.Name = "cmbKolam";
            cmbKolam.Size = new Size(121, 23);
            cmbKolam.TabIndex = 0;
            // 
            // dtpTanggal
            // 
            dtpTanggal.CustomFormat = "11/11/2026";
            dtpTanggal.Location = new Point(142, 102);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(135, 23);
            dtpTanggal.TabIndex = 2;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(283, 102);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(121, 23);
            cmbKategori.TabIndex = 3;
            // 
            // txtKeterangan
            // 
            txtKeterangan.Location = new Point(410, 102);
            txtKeterangan.Name = "txtKeterangan";
            txtKeterangan.Size = new Size(100, 23);
            txtKeterangan.TabIndex = 4;
            // 
            // lblKolam
            // 
            lblKolam.AutoSize = true;
            lblKolam.Location = new Point(15, 84);
            lblKolam.Name = "lblKolam";
            lblKolam.Size = new Size(41, 15);
            lblKolam.TabIndex = 5;
            lblKolam.Text = "Kolam";
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.Location = new Point(142, 84);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(48, 15);
            lblTanggal.TabIndex = 6;
            lblTanggal.Text = "Tanggal";
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(283, 84);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(51, 15);
            lblKategori.TabIndex = 7;
            lblKategori.Text = "Kategori";
            // 
            // lblKeterangan
            // 
            lblKeterangan.AutoSize = true;
            lblKeterangan.Location = new Point(410, 84);
            lblKeterangan.Name = "lblKeterangan";
            lblKeterangan.Size = new Size(67, 15);
            lblKeterangan.TabIndex = 8;
            lblKeterangan.Text = "Keterangan";
            // 
            // lblJumlah
            // 
            lblJumlah.AutoSize = true;
            lblJumlah.Location = new Point(516, 84);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(70, 15);
            lblJumlah.TabIndex = 9;
            lblJumlah.Text = "Jumlah (Rp)";
            // 
            // txtJumlah
            // 
            txtJumlah.Location = new Point(516, 102);
            txtJumlah.Name = "txtJumlah";
            txtJumlah.Size = new Size(100, 23);
            txtJumlah.TabIndex = 10;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(15, 144);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(75, 23);
            btnTambah.TabIndex = 11;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            // 
            // btnUbah
            // 
            btnUbah.Location = new Point(96, 144);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(75, 23);
            btnUbah.TabIndex = 12;
            btnUbah.Text = "Ubah";
            btnUbah.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(177, 144);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(75, 23);
            btnHapus.TabIndex = 13;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnBersihkan
            // 
            btnBersihkan.Location = new Point(259, 144);
            btnBersihkan.Name = "btnBersihkan";
            btnBersihkan.Size = new Size(75, 23);
            btnBersihkan.TabIndex = 14;
            btnBersihkan.Text = "Bersihkan";
            btnBersihkan.UseVisualStyleBackColor = true;
            // 
            // dgvPengeluaran
            // 
            dgvPengeluaran.AllowUserToAddRows = false;
            dgvPengeluaran.AllowUserToDeleteRows = false;
            dgvPengeluaran.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPengeluaran.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPengeluaran.Location = new Point(15, 182);
            dgvPengeluaran.MultiSelect = false;
            dgvPengeluaran.Name = "dgvPengeluaran";
            dgvPengeluaran.ReadOnly = true;
            dgvPengeluaran.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPengeluaran.Size = new Size(941, 188);
            dgvPengeluaran.TabIndex = 15;
            // 
            // UcPengeluaran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dgvPengeluaran);
            Controls.Add(btnBersihkan);
            Controls.Add(btnHapus);
            Controls.Add(btnUbah);
            Controls.Add(btnTambah);
            Controls.Add(txtJumlah);
            Controls.Add(lblJumlah);
            Controls.Add(lblKeterangan);
            Controls.Add(lblKategori);
            Controls.Add(lblTanggal);
            Controls.Add(lblKolam);
            Controls.Add(txtKeterangan);
            Controls.Add(cmbKategori);
            Controls.Add(dtpTanggal);
            Controls.Add(cmbKolam);
            Name = "UcPengeluaran";
            Size = new Size(982, 429);
            ((System.ComponentModel.ISupportInitialize)dgvPengeluaran).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbKolam;
        private DateTimePicker dtpTanggal;
        private ComboBox cmbKategori;
        private TextBox txtKeterangan;
        private Label lblKolam;
        private Label lblTanggal;
        private Label lblKategori;
        private Label lblKeterangan;
        private Label lblJumlah;
        private TextBox txtJumlah;
        private Button btnTambah;
        private Button btnUbah;
        private Button btnHapus;
        private Button btnBersihkan;
        private DataGridView dgvPengeluaran;
    }
}