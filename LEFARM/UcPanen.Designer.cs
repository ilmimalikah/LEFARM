namespace LEFARM
{
    partial class UcPanen
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
            lblKolam = new Label();
            cmbKolam = new ComboBox();
            lblTanggalPanen = new Label();
            dtpTanggalPanen = new DateTimePicker();
            lblBeratKg = new Label();
            txtBeratKg = new TextBox();
            lblHargaPerKg = new Label();
            txtHargaPerKg = new TextBox();
            lblTotalHarga = new Label();
            txtTotalHarga = new TextBox();
            btnTambah = new Button();
            btnUbah = new Button();
            btnHapus = new Button();
            btnBersihkan = new Button();
            dgvPanen = new DataGridView();
            lblDataPanen = new Label();
            colIdPanen = new DataGridViewTextBoxColumn();
            colKolam = new DataGridViewTextBoxColumn();
            colTanggalPanen = new DataGridViewTextBoxColumn();
            colBeratKg = new DataGridViewTextBoxColumn();
            colHargaPerKg = new DataGridViewTextBoxColumn();
            colTotalHarga = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPanen).BeginInit();
            SuspendLayout();
            // 
            // lblKolam
            // 
            lblKolam.AutoSize = true;
            lblKolam.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKolam.Location = new Point(21, 93);
            lblKolam.Margin = new Padding(4, 0, 4, 0);
            lblKolam.Name = "lblKolam";
            lblKolam.Size = new Size(60, 22);
            lblKolam.TabIndex = 0;
            lblKolam.Text = "Kolam";
            lblKolam.TextAlign = ContentAlignment.BottomRight;
            lblKolam.UseMnemonic = false;
            // 
            // cmbKolam
            // 
            cmbKolam.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKolam.FormattingEnabled = true;
            cmbKolam.Location = new Point(21, 118);
            cmbKolam.Name = "cmbKolam";
            cmbKolam.Size = new Size(156, 40);
            cmbKolam.TabIndex = 1;
            // 
            // lblTanggalPanen
            // 
            lblTanggalPanen.AutoSize = true;
            lblTanggalPanen.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTanggalPanen.Location = new Point(183, 93);
            lblTanggalPanen.Name = "lblTanggalPanen";
            lblTanggalPanen.Size = new Size(133, 22);
            lblTanggalPanen.TabIndex = 2;
            lblTanggalPanen.Text = "Tanggal Panen";
            lblTanggalPanen.Click += lblTanggalPanen_Click;
            // 
            // dtpTanggalPanen
            // 
            dtpTanggalPanen.CustomFormat = "dd/MM/yyyy";
            dtpTanggalPanen.Format = DateTimePickerFormat.Custom;
            dtpTanggalPanen.Location = new Point(183, 121);
            dtpTanggalPanen.Name = "dtpTanggalPanen";
            dtpTanggalPanen.Size = new Size(172, 39);
            dtpTanggalPanen.TabIndex = 3;
            // 
            // lblBeratKg
            // 
            lblBeratKg.AutoSize = true;
            lblBeratKg.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBeratKg.Location = new Point(378, 93);
            lblBeratKg.Name = "lblBeratKg";
            lblBeratKg.Size = new Size(92, 22);
            lblBeratKg.TabIndex = 4;
            lblBeratKg.Text = "Berat (Kg)";
            // 
            // txtBeratKg
            // 
            txtBeratKg.Location = new Point(378, 121);
            txtBeratKg.Name = "txtBeratKg";
            txtBeratKg.Size = new Size(150, 39);
            txtBeratKg.TabIndex = 5;
            // 
            // lblHargaPerKg
            // 
            lblHargaPerKg.AutoSize = true;
            lblHargaPerKg.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHargaPerKg.Location = new Point(548, 93);
            lblHargaPerKg.Name = "lblHargaPerKg";
            lblHargaPerKg.Size = new Size(117, 22);
            lblHargaPerKg.TabIndex = 6;
            lblHargaPerKg.Text = "Harga per Kg";
            // 
            // txtHargaPerKg
            // 
            txtHargaPerKg.Location = new Point(548, 121);
            txtHargaPerKg.Name = "txtHargaPerKg";
            txtHargaPerKg.Size = new Size(172, 39);
            txtHargaPerKg.TabIndex = 7;
            // 
            // lblTotalHarga
            // 
            lblTotalHarga.AutoSize = true;
            lblTotalHarga.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalHarga.Location = new Point(740, 93);
            lblTotalHarga.Name = "lblTotalHarga";
            lblTotalHarga.Size = new Size(105, 22);
            lblTotalHarga.TabIndex = 8;
            lblTotalHarga.Text = "Total Harga";
            lblTotalHarga.Click += lblTotalHarga_Click;
            // 
            // txtTotalHarga
            // 
            txtTotalHarga.Location = new Point(740, 121);
            txtTotalHarga.Name = "txtTotalHarga";
            txtTotalHarga.Size = new Size(217, 39);
            txtTotalHarga.TabIndex = 9;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.FromArgb(255, 128, 255);
            btnTambah.Location = new Point(21, 175);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(206, 42);
            btnTambah.TabIndex = 10;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            // 
            // btnUbah
            // 
            btnUbah.BackColor = Color.PaleGreen;
            btnUbah.Location = new Point(249, 175);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(210, 42);
            btnUbah.TabIndex = 11;
            btnUbah.Text = "Ubah";
            btnUbah.UseVisualStyleBackColor = false;
            btnUbah.Click += btnUbah_Click;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.HotPink;
            btnHapus.Location = new Point(479, 175);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(211, 42);
            btnHapus.TabIndex = 12;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            // 
            // btnBersihkan
            // 
            btnBersihkan.BackColor = Color.FromArgb(128, 128, 255);
            btnBersihkan.Location = new Point(707, 175);
            btnBersihkan.Name = "btnBersihkan";
            btnBersihkan.Size = new Size(250, 42);
            btnBersihkan.TabIndex = 13;
            btnBersihkan.Text = "Bersihkan";
            btnBersihkan.UseVisualStyleBackColor = false;
            // 
            // dgvPanen
            // 
            dgvPanen.AllowUserToAddRows = false;
            dgvPanen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPanen.BackgroundColor = SystemColors.ControlLightLight;
            dgvPanen.ColumnHeadersHeight = 45;
            dgvPanen.Columns.AddRange(new DataGridViewColumn[] { colIdPanen, colKolam, colTanggalPanen, colBeratKg, colHargaPerKg, colTotalHarga });
            dgvPanen.Location = new Point(21, 223);
            dgvPanen.Name = "dgvPanen";
            dgvPanen.ReadOnly = true;
            dgvPanen.RowHeadersVisible = false;
            dgvPanen.RowHeadersWidth = 62;
            dgvPanen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPanen.Size = new Size(936, 157);
            dgvPanen.TabIndex = 14;
            dgvPanen.CellContentClick += dgvPanen_CellContentClick;
            // 
            // lblDataPanen
            // 
            lblDataPanen.AutoSize = true;
            lblDataPanen.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDataPanen.Location = new Point(21, 16);
            lblDataPanen.Name = "lblDataPanen";
            lblDataPanen.Size = new Size(182, 29);
            lblDataPanen.TabIndex = 15;
            lblDataPanen.Text = "Keuangan > Panen";
            lblDataPanen.Click += lblDataPanen_Click;
            // 
            // colIdPanen
            // 
            colIdPanen.HeaderText = "ID";
            colIdPanen.MinimumWidth = 8;
            colIdPanen.Name = "colIdPanen";
            colIdPanen.ReadOnly = true;
            // 
            // colKolam
            // 
            colKolam.HeaderText = "Kolam";
            colKolam.MinimumWidth = 8;
            colKolam.Name = "colKolam";
            colKolam.ReadOnly = true;
            // 
            // colTanggalPanen
            // 
            colTanggalPanen.HeaderText = "Tanggal Panen";
            colTanggalPanen.MinimumWidth = 8;
            colTanggalPanen.Name = "colTanggalPanen";
            colTanggalPanen.ReadOnly = true;
            // 
            // colBeratKg
            // 
            colBeratKg.HeaderText = "Berat (kg)";
            colBeratKg.MinimumWidth = 8;
            colBeratKg.Name = "colBeratKg";
            colBeratKg.ReadOnly = true;
            // 
            // colHargaPerKg
            // 
            colHargaPerKg.HeaderText = "Harga per kg";
            colHargaPerKg.MinimumWidth = 8;
            colHargaPerKg.Name = "colHargaPerKg";
            colHargaPerKg.ReadOnly = true;
            // 
            // colTotalHarga
            // 
            colTotalHarga.HeaderText = "Total Harga";
            colTotalHarga.MinimumWidth = 8;
            colTotalHarga.Name = "colTotalHarga";
            colTotalHarga.ReadOnly = true;
            // 
            // UcPanen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            CausesValidation = false;
            Controls.Add(lblDataPanen);
            Controls.Add(dgvPanen);
            Controls.Add(btnBersihkan);
            Controls.Add(btnHapus);
            Controls.Add(btnUbah);
            Controls.Add(btnTambah);
            Controls.Add(txtTotalHarga);
            Controls.Add(lblTotalHarga);
            Controls.Add(txtHargaPerKg);
            Controls.Add(lblHargaPerKg);
            Controls.Add(txtBeratKg);
            Controls.Add(lblBeratKg);
            Controls.Add(dtpTanggalPanen);
            Controls.Add(lblTanggalPanen);
            Controls.Add(cmbKolam);
            Controls.Add(lblKolam);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "UcPanen";
            Size = new Size(982, 429);
            ((System.ComponentModel.ISupportInitialize)dgvPanen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKolam;
        private ComboBox cmbKolam;
        private Label lblTanggalPanen;
        private DateTimePicker dtpTanggalPanen;
        private Label lblBeratKg;
        private TextBox txtBeratKg;
        private Label lblHargaPerKg;
        private TextBox txtHargaPerKg;
        private Label lblTotalHarga;
        private TextBox txtTotalHarga;
        private Button btnTambah;
        private Button btnUbah;
        private Button btnHapus;
        private Button btnBersihkan;
        private DataGridView dgvPanen;
        private Label lblDataPanen;
        private DataGridViewTextBoxColumn colIdPanen;
        private DataGridViewTextBoxColumn colKolam;
        private DataGridViewTextBoxColumn colTanggalPanen;
        private DataGridViewTextBoxColumn colBeratKg;
        private DataGridViewTextBoxColumn colHargaPerKg;
        private DataGridViewTextBoxColumn colTotalHarga;
    }
}