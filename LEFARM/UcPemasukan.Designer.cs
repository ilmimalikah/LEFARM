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
            cmbKolam.Location = new Point(11, 58);
            cmbKolam.Margin = new Padding(3, 4, 3, 4);
            cmbKolam.Name = "cmbKolam";
            cmbKolam.Size = new Size(138, 28);
            cmbKolam.TabIndex = 0;
            // 
            // dtpTanggal
            // 
            dtpTanggal.CustomFormat = "11/11/2026";
            dtpTanggal.Location = new Point(157, 58);
            dtpTanggal.Margin = new Padding(3, 4, 3, 4);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(154, 27);
            dtpTanggal.TabIndex = 1;
            // 
            // txtKeterangan
            // 
            txtKeterangan.Location = new Point(319, 58);
            txtKeterangan.Margin = new Padding(3, 4, 3, 4);
            txtKeterangan.Name = "txtKeterangan";
            txtKeterangan.Size = new Size(114, 27);
            txtKeterangan.TabIndex = 2;
            // 
            // txtJumlah
            // 
            txtJumlah.Location = new Point(440, 58);
            txtJumlah.Margin = new Padding(3, 4, 3, 4);
            txtJumlah.Name = "txtJumlah";
            txtJumlah.Size = new Size(114, 27);
            txtJumlah.TabIndex = 3;
            // 
            // lblKolam
            // 
            lblKolam.AutoSize = true;
            lblKolam.Location = new Point(11, 34);
            lblKolam.Name = "lblKolam";
            lblKolam.Size = new Size(52, 20);
            lblKolam.TabIndex = 4;
            lblKolam.Text = "Kolam";
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.Location = new Point(157, 34);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(61, 20);
            lblTanggal.TabIndex = 5;
            lblTanggal.Text = "Tanggal";
            // 
            // lblKeterangan
            // 
            lblKeterangan.AutoSize = true;
            lblKeterangan.Location = new Point(319, 34);
            lblKeterangan.Name = "lblKeterangan";
            lblKeterangan.Size = new Size(85, 20);
            lblKeterangan.TabIndex = 6;
            lblKeterangan.Text = "Keterangan";
            // 
            // lblJumlah
            // 
            lblJumlah.AutoSize = true;
            lblJumlah.Location = new Point(440, 34);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(87, 20);
            lblJumlah.TabIndex = 7;
            lblJumlah.Text = "Jumlah (Rp)";
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(11, 112);
            btnTambah.Margin = new Padding(3, 4, 3, 4);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(86, 31);
            btnTambah.TabIndex = 8;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            // 
            // btnUbah
            // 
            btnUbah.Location = new Point(104, 112);
            btnUbah.Margin = new Padding(3, 4, 3, 4);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(86, 31);
            btnUbah.TabIndex = 9;
            btnUbah.Text = "Ubah";
            btnUbah.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(197, 112);
            btnHapus.Margin = new Padding(3, 4, 3, 4);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(86, 31);
            btnHapus.TabIndex = 10;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnBersihkan
            // 
            btnBersihkan.Location = new Point(289, 112);
            btnBersihkan.Margin = new Padding(3, 4, 3, 4);
            btnBersihkan.Name = "btnBersihkan";
            btnBersihkan.Size = new Size(86, 31);
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
            dgvPemasukan.Location = new Point(11, 164);
            dgvPemasukan.Margin = new Padding(3, 4, 3, 4);
            dgvPemasukan.MultiSelect = false;
            dgvPemasukan.Name = "dgvPemasukan";
            dgvPemasukan.ReadOnly = true;
            dgvPemasukan.RowHeadersVisible = false;
            dgvPemasukan.RowHeadersWidth = 51;
            dgvPemasukan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPemasukan.Size = new Size(949, 255);
            dgvPemasukan.TabIndex = 12;
            // 
            // UcPemasukan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "UcPemasukan";
            Size = new Size(859, 322);
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