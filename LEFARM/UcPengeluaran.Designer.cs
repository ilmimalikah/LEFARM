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
            cmbKolam.Location = new Point(12, 54);
            cmbKolam.Margin = new Padding(3, 4, 3, 4);
            cmbKolam.Name = "cmbKolam";
            cmbKolam.Size = new Size(138, 28);
            cmbKolam.TabIndex = 0;
            // 
            // dtpTanggal
            // 
            dtpTanggal.CustomFormat = "11/11/2026";
            dtpTanggal.Location = new Point(157, 54);
            dtpTanggal.Margin = new Padding(3, 4, 3, 4);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(154, 27);
            dtpTanggal.TabIndex = 2;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(318, 54);
            cmbKategori.Margin = new Padding(3, 4, 3, 4);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(138, 28);
            cmbKategori.TabIndex = 3;
            // 
            // txtKeterangan
            // 
            txtKeterangan.Location = new Point(464, 54);
            txtKeterangan.Margin = new Padding(3, 4, 3, 4);
            txtKeterangan.Name = "txtKeterangan";
            txtKeterangan.Size = new Size(114, 27);
            txtKeterangan.TabIndex = 4;
            // 
            // lblKolam
            // 
            lblKolam.AutoSize = true;
            lblKolam.Location = new Point(12, 30);
            lblKolam.Name = "lblKolam";
            lblKolam.Size = new Size(52, 20);
            lblKolam.TabIndex = 5;
            lblKolam.Text = "Kolam";
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.Location = new Point(157, 30);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(61, 20);
            lblTanggal.TabIndex = 6;
            lblTanggal.Text = "Tanggal";
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(318, 30);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(66, 20);
            lblKategori.TabIndex = 7;
            lblKategori.Text = "Kategori";
            // 
            // lblKeterangan
            // 
            lblKeterangan.AutoSize = true;
            lblKeterangan.Location = new Point(464, 30);
            lblKeterangan.Name = "lblKeterangan";
            lblKeterangan.Size = new Size(85, 20);
            lblKeterangan.TabIndex = 8;
            lblKeterangan.Text = "Keterangan";
            // 
            // lblJumlah
            // 
            lblJumlah.AutoSize = true;
            lblJumlah.Location = new Point(585, 30);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(87, 20);
            lblJumlah.TabIndex = 9;
            lblJumlah.Text = "Jumlah (Rp)";
            // 
            // txtJumlah
            // 
            txtJumlah.Location = new Point(585, 54);
            txtJumlah.Margin = new Padding(3, 4, 3, 4);
            txtJumlah.Name = "txtJumlah";
            txtJumlah.Size = new Size(114, 27);
            txtJumlah.TabIndex = 10;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(12, 110);
            btnTambah.Margin = new Padding(3, 4, 3, 4);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(86, 31);
            btnTambah.TabIndex = 11;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            // 
            // btnUbah
            // 
            btnUbah.Location = new Point(105, 110);
            btnUbah.Margin = new Padding(3, 4, 3, 4);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(86, 31);
            btnUbah.TabIndex = 12;
            btnUbah.Text = "Ubah";
            btnUbah.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(197, 110);
            btnHapus.Margin = new Padding(3, 4, 3, 4);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(86, 31);
            btnHapus.TabIndex = 13;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnBersihkan
            // 
            btnBersihkan.Location = new Point(291, 110);
            btnBersihkan.Margin = new Padding(3, 4, 3, 4);
            btnBersihkan.Name = "btnBersihkan";
            btnBersihkan.Size = new Size(86, 31);
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
            dgvPengeluaran.Location = new Point(12, 161);
            dgvPengeluaran.Margin = new Padding(3, 4, 3, 4);
            dgvPengeluaran.MultiSelect = false;
            dgvPengeluaran.Name = "dgvPengeluaran";
            dgvPengeluaran.ReadOnly = true;
            dgvPengeluaran.RowHeadersWidth = 51;
            dgvPengeluaran.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPengeluaran.Size = new Size(951, 251);
            dgvPengeluaran.TabIndex = 15;
            // 
            // UcPengeluaran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
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
            Margin = new Padding(3, 4, 3, 4);
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