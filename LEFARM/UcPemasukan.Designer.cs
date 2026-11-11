namespace LEFARM
{
    partial class UcPemasukan
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
            txtKeterangan = new TextBox();
            txtJumlah = new TextBox();
            lblKolam = new Label();
            lblTanggal = new Label();
            lblKeterangan = new Label();
            lblJumlah = new Label();
            btnTambah = new Button();
            btnUbah = new Button();
            btnHapus = new Button();
            btnBersihkan = new Button();
            dgvPemasukan = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPemasukan).BeginInit();
            SuspendLayout();
            // 
            // cmbKolam
            // 
            cmbKolam.FormattingEnabled = true;
            cmbKolam.Location = new Point(20, 88);
            cmbKolam.Name = "cmbKolam";
            cmbKolam.Size = new Size(121, 23);
            cmbKolam.TabIndex = 0;
            // 
            // dtpTanggal
            // 
            dtpTanggal.CustomFormat = "11/11/2026";
            dtpTanggal.Location = new Point(147, 88);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(135, 23);
            dtpTanggal.TabIndex = 1;
            // 
            // txtKeterangan
            // 
            txtKeterangan.Location = new Point(289, 88);
            txtKeterangan.Name = "txtKeterangan";
            txtKeterangan.Size = new Size(100, 23);
            txtKeterangan.TabIndex = 2;
            // 
            // txtJumlah
            // 
            txtJumlah.Location = new Point(395, 88);
            txtJumlah.Name = "txtJumlah";
            txtJumlah.Size = new Size(100, 23);
            txtJumlah.TabIndex = 3;
            // 
            // lblKolam
            // 
            lblKolam.AutoSize = true;
            lblKolam.Location = new Point(20, 70);
            lblKolam.Name = "lblKolam";
            lblKolam.Size = new Size(41, 15);
            lblKolam.TabIndex = 4;
            lblKolam.Text = "Kolam";
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.Location = new Point(147, 70);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(48, 15);
            lblTanggal.TabIndex = 5;
            lblTanggal.Text = "Tanggal";
            // 
            // lblKeterangan
            // 
            lblKeterangan.AutoSize = true;
            lblKeterangan.Location = new Point(289, 70);
            lblKeterangan.Name = "lblKeterangan";
            lblKeterangan.Size = new Size(67, 15);
            lblKeterangan.TabIndex = 6;
            lblKeterangan.Text = "Keterangan";
            // 
            // lblJumlah
            // 
            lblJumlah.AutoSize = true;
            lblJumlah.Location = new Point(395, 70);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(70, 15);
            lblJumlah.TabIndex = 7;
            lblJumlah.Text = "Jumlah (Rp)";
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(20, 129);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(75, 23);
            btnTambah.TabIndex = 8;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            // 
            // btnUbah
            // 
            btnUbah.Location = new Point(101, 129);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(75, 23);
            btnUbah.TabIndex = 9;
            btnUbah.Text = "Ubah";
            btnUbah.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(182, 129);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(75, 23);
            btnHapus.TabIndex = 10;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnBersihkan
            // 
            btnBersihkan.Location = new Point(263, 129);
            btnBersihkan.Name = "btnBersihkan";
            btnBersihkan.Size = new Size(75, 23);
            btnBersihkan.TabIndex = 11;
            btnBersihkan.Text = "Bersihkan";
            btnBersihkan.UseVisualStyleBackColor = true;
            // 
            // dgvPemasukan
            // 
            dgvPemasukan.AllowUserToAddRows = false;
            dgvPemasukan.AllowUserToDeleteRows = false;
            dgvPemasukan.AllowUserToResizeRows = false;
            dgvPemasukan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPemasukan.BackgroundColor = Color.White;
            dgvPemasukan.BorderStyle = BorderStyle.Fixed3D;
            dgvPemasukan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPemasukan.Location = new Point(20, 168);
            dgvPemasukan.MultiSelect = false;
            dgvPemasukan.Name = "dgvPemasukan";
            dgvPemasukan.ReadOnly = true;
            dgvPemasukan.RowHeadersVisible = false;
            dgvPemasukan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPemasukan.Size = new Size(939, 191);
            dgvPemasukan.TabIndex = 12;
            // 
            // UcPemasukan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dgvPemasukan);
            Controls.Add(btnBersihkan);
            Controls.Add(btnHapus);
            Controls.Add(btnUbah);
            Controls.Add(btnTambah);
            Controls.Add(lblJumlah);
            Controls.Add(lblKeterangan);
            Controls.Add(lblTanggal);
            Controls.Add(lblKolam);
            Controls.Add(txtJumlah);
            Controls.Add(txtKeterangan);
            Controls.Add(dtpTanggal);
            Controls.Add(cmbKolam);
            Name = "UcPemasukan";
            Size = new Size(982, 429);
            ((System.ComponentModel.ISupportInitialize)dgvPemasukan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbKolam;
        private DateTimePicker dtpTanggal;
        private TextBox txtKeterangan;
        private TextBox txtJumlah;
        private Label lblKolam;
        private Label lblTanggal;
        private Label lblKeterangan;
        private Label lblJumlah;
        private Button btnTambah;
        private Button btnUbah;
        private Button btnHapus;
        private Button btnBersihkan;
        private DataGridView dgvPemasukan;
    }
}