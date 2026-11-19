namespace LEFARM
{
    partial class UcPanen
    {
        private System.ComponentModel.IContainer components = null;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            lblKolam.Location = new Point(21, 23);
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
            cmbKolam.Location = new Point(21, 48);
            cmbKolam.Name = "cmbKolam";
            cmbKolam.Size = new Size(156, 40);
            cmbKolam.TabIndex = 1;
            // 
            // lblTanggalPanen
            // 
            lblTanggalPanen.AutoSize = true;
            lblTanggalPanen.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTanggalPanen.Location = new Point(183, 23);
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
            dtpTanggalPanen.Location = new Point(183, 49);
            dtpTanggalPanen.Name = "dtpTanggalPanen";
            dtpTanggalPanen.Size = new Size(172, 39);
            dtpTanggalPanen.TabIndex = 3;
            // 
            // lblBeratKg
            // 
            lblBeratKg.AutoSize = true;
            lblBeratKg.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBeratKg.Location = new Point(361, 23);
            lblBeratKg.Name = "lblBeratKg";
            lblBeratKg.Size = new Size(92, 22);
            lblBeratKg.TabIndex = 4;
            lblBeratKg.Text = "Berat (Kg)";
            lblBeratKg.Click += lblBeratKg_Click;
            // 
            // txtBeratKg
            // 
            txtBeratKg.Location = new Point(361, 51);
            txtBeratKg.Name = "txtBeratKg";
            txtBeratKg.Size = new Size(150, 39);
            txtBeratKg.TabIndex = 5;
            // 
            // lblHargaPerKg
            // 
            lblHargaPerKg.AutoSize = true;
            lblHargaPerKg.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHargaPerKg.Location = new Point(517, 23);
            lblHargaPerKg.Name = "lblHargaPerKg";
            lblHargaPerKg.Size = new Size(117, 22);
            lblHargaPerKg.TabIndex = 6;
            lblHargaPerKg.Text = "Harga per Kg";
            // 
            // txtHargaPerKg
            // 
            txtHargaPerKg.Location = new Point(518, 51);
            txtHargaPerKg.Name = "txtHargaPerKg";
            txtHargaPerKg.Size = new Size(172, 39);
            txtHargaPerKg.TabIndex = 7;
            // 
            // lblTotalHarga
            // 
            lblTotalHarga.AutoSize = true;
            lblTotalHarga.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalHarga.Location = new Point(696, 23);
            lblTotalHarga.Name = "lblTotalHarga";
            lblTotalHarga.Size = new Size(105, 22);
            lblTotalHarga.TabIndex = 8;
            lblTotalHarga.Text = "Total Harga";
            lblTotalHarga.Click += lblTotalHarga_Click;
            // 
            // txtTotalHarga
            // 
            txtTotalHarga.Location = new Point(696, 51);
            txtTotalHarga.Name = "txtTotalHarga";
            txtTotalHarga.Size = new Size(217, 39);
            txtTotalHarga.TabIndex = 9;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.FromArgb(255, 128, 255);
            btnTambah.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTambah.Location = new Point(21, 103);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(88, 44);
            btnTambah.TabIndex = 10;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            // 
            // btnUbah
            // 
            btnUbah.BackColor = Color.PaleGreen;
            btnUbah.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUbah.Location = new Point(115, 105);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(84, 42);
            btnUbah.TabIndex = 11;
            btnUbah.Text = "Ubah";
            btnUbah.UseVisualStyleBackColor = false;
            btnUbah.Click += btnUbah_Click;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.HotPink;
            btnHapus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHapus.Location = new Point(205, 105);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(87, 42);
            btnHapus.TabIndex = 12;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            // 
            // btnBersihkan
            // 
            btnBersihkan.BackColor = Color.FromArgb(128, 128, 255);
            btnBersihkan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBersihkan.Location = new Point(298, 105);
            btnBersihkan.Name = "btnBersihkan";
            btnBersihkan.Size = new Size(96, 42);
            btnBersihkan.TabIndex = 13;
            btnBersihkan.Text = "Bersihkan";
            btnBersihkan.UseVisualStyleBackColor = false;
            // 
            // dgvPanen
            // 
            dgvPanen.AllowUserToAddRows = false;
            dgvPanen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPanen.BackgroundColor = SystemColors.ButtonFace;
            dgvPanen.ColumnHeadersHeight = 45;
            dgvPanen.Columns.AddRange(new DataGridViewColumn[] { colIdPanen, colKolam, colTanggalPanen, colBeratKg, colHargaPerKg, colTotalHarga });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvPanen.DefaultCellStyle = dataGridViewCellStyle1;
            dgvPanen.Location = new Point(21, 153);
            dgvPanen.Name = "dgvPanen";
            dgvPanen.ReadOnly = true;
            dgvPanen.RowHeadersVisible = false;
            dgvPanen.RowHeadersWidth = 62;
            dgvPanen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPanen.Size = new Size(936, 264);
            dgvPanen.TabIndex = 14;
            dgvPanen.CellContentClick += dgvPanen_CellContentClick;
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
            colHargaPerKg.HeaderText = "Harga 1 kg";
            colHargaPerKg.MinimumWidth = 8;
            colHargaPerKg.Name = "colHargaPerKg";
            colHargaPerKg.ReadOnly = true;
            colHargaPerKg.ToolTipText = " ";
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
            Margin = new Padding(4);
            Name = "UcPanen";
            Size = new Size(982, 429);
            Load += UcPanen_Load;
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
        private DataGridViewTextBoxColumn colIdPanen;
        private DataGridViewTextBoxColumn colKolam;
        private DataGridViewTextBoxColumn colTanggalPanen;
        private DataGridViewTextBoxColumn colBeratKg;
        private DataGridViewTextBoxColumn colHargaPerKg;
        private DataGridViewTextBoxColumn colTotalHarga;
    }
}