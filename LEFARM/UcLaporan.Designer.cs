namespace LEFARM
{
    public partial class UcLaporan : UserControl
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

        private void InitializeComponent()
        {
            lblBulan = new Label();
            cmbBulan = new ComboBox();
            lblKolam = new Label();
            cmbKolam = new ComboBox();
            btnTampilkan = new Button();
            btnCetak = new Button();
            btnEksporExcel = new Button();
            panelPemasukan = new Panel();
            lblNominalPemasukan = new Label();
            lblJudulPemasukan = new Label();
            panel1 = new Panel();
            lblJudulPengeluaran = new Label();
            lblNominalPengeluaran = new Label();
            panelLabaRugi = new Panel();
            lblJudulLabaRugi = new Label();
            lblNominalLabaRugi = new Label();
            dgvLaporan = new DataGridView();
            colTanggal = new DataGridViewTextBoxColumn();
            colJenis = new DataGridViewTextBoxColumn();
            colKeterangan = new DataGridViewTextBoxColumn();
            colJumlah = new DataGridViewTextBoxColumn();

            panelPemasukan.SuspendLayout();
            panel1.SuspendLayout();
            panelLabaRugi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLaporan).BeginInit();
            SuspendLayout();

            lblBulan.AutoSize = true;
            lblBulan.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBulan.Location = new Point(38, 55);
            lblBulan.Name = "lblBulan";
            lblBulan.Size = new Size(56, 22);
            lblBulan.TabIndex = 0;
            lblBulan.Text = "Bulan";

            cmbBulan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBulan.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBulan.FormattingEnabled = true;
            cmbBulan.Location = new Point(43, 77);
            cmbBulan.Name = "cmbBulan";
            cmbBulan.Size = new Size(182, 30);
            cmbBulan.TabIndex = 1;

            lblKolam.AutoSize = true;
            lblKolam.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKolam.Location = new Point(242, 55);
            lblKolam.Name = "lblKolam";
            lblKolam.Size = new Size(60, 22);
            lblKolam.TabIndex = 2;
            lblKolam.Text = "Kolam";

            cmbKolam.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKolam.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbKolam.FormattingEnabled = true;
            cmbKolam.Location = new Point(245, 77);
            cmbKolam.Name = "cmbKolam";
            cmbKolam.Size = new Size(182, 30);
            cmbKolam.TabIndex = 3;

            btnTampilkan.BackColor = Color.FromArgb(128, 128, 255);
            btnTampilkan.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTampilkan.Location = new Point(442, 55);
            btnTampilkan.Name = "btnTampilkan";
            btnTampilkan.Size = new Size(149, 52);
            btnTampilkan.TabIndex = 4;
            btnTampilkan.Text = "Tampilkan";
            btnTampilkan.UseVisualStyleBackColor = false;

            btnCetak.BackColor = Color.FromArgb(255, 128, 255);
            btnCetak.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCetak.Location = new Point(612, 55);
            btnCetak.Name = "btnCetak";
            btnCetak.Size = new Size(140, 52);
            btnCetak.TabIndex = 5;
            btnCetak.Text = "Cetak";
            btnCetak.UseVisualStyleBackColor = false;

            btnEksporExcel.BackColor = Color.FromArgb(128, 255, 255);
            btnEksporExcel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEksporExcel.Location = new Point(775, 55);
            btnEksporExcel.Name = "btnEksporExcel";
            btnEksporExcel.Size = new Size(161, 52);
            btnEksporExcel.TabIndex = 6;
            btnEksporExcel.Text = "Ekspor Excel";
            btnEksporExcel.UseVisualStyleBackColor = false;

            panelPemasukan.Controls.Add(lblNominalPemasukan);
            panelPemasukan.Controls.Add(lblJudulPemasukan);
            panelPemasukan.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelPemasukan.Location = new Point(43, 122);
            panelPemasukan.Name = "panelPemasukan";
            panelPemasukan.Size = new Size(299, 76);
            panelPemasukan.TabIndex = 7;

            lblNominalPemasukan.AutoSize = true;
            lblNominalPemasukan.Location = new Point(13, 41);
            lblNominalPemasukan.Name = "lblNominalPemasukan";
            lblNominalPemasukan.Size = new Size(48, 22);
            lblNominalPemasukan.TabIndex = 8;
            lblNominalPemasukan.Text = "Rp 0";

            lblJudulPemasukan.AutoSize = true;
            lblJudulPemasukan.ForeColor = SystemColors.ActiveCaptionText;
            lblJudulPemasukan.Location = new Point(3, 9);
            lblJudulPemasukan.Name = "lblJudulPemasukan";
            lblJudulPemasukan.Size = new Size(295, 22);
            lblJudulPemasukan.TabIndex = 8;
            lblJudulPemasukan.Text = "Total Pemasukan (termasuk panen)";
            lblJudulPemasukan.Click += lblJudulPemasukan_Click;

            panel1.Controls.Add(lblNominalPengeluaran);
            panel1.Controls.Add(lblJudulPengeluaran);
            panel1.Location = new Point(360, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 77);
            panel1.TabIndex = 8;

            lblJudulPengeluaran.AutoSize = true;
            lblJudulPengeluaran.Location = new Point(14, 9);
            lblJudulPengeluaran.Name = "lblJudulPengeluaran";
            lblJudulPengeluaran.Size = new Size(158, 22);
            lblJudulPengeluaran.TabIndex = 9;
            lblJudulPengeluaran.Text = "Total Pengeluaran";

            lblNominalPengeluaran.AutoSize = true;
            lblNominalPengeluaran.Location = new Point(14, 41);
            lblNominalPengeluaran.Name = "lblNominalPengeluaran";
            lblNominalPengeluaran.Size = new Size(48, 22);
            lblNominalPengeluaran.TabIndex = 10;
            lblNominalPengeluaran.Text = "Rp 0";

            panelLabaRugi.Controls.Add(lblNominalLabaRugi);
            panelLabaRugi.Controls.Add(lblJudulLabaRugi);
            panelLabaRugi.Location = new Point(677, 122);
            panelLabaRugi.Name = "panelLabaRugi";
            panelLabaRugi.Size = new Size(259, 76);
            panelLabaRugi.TabIndex = 9;

            lblJudulLabaRugi.AutoSize = true;
            lblJudulLabaRugi.Location = new Point(14, 8);
            lblJudulLabaRugi.Name = "lblJudulLabaRugi";
            lblJudulLabaRugi.Size = new Size(102, 22);
            lblJudulLabaRugi.TabIndex = 0;
            lblJudulLabaRugi.Text = "Laba / Rugi";

            lblNominalLabaRugi.AutoSize = true;
            lblNominalLabaRugi.Location = new Point(14, 37);
            lblNominalLabaRugi.Name = "lblNominalLabaRugi";
            lblNominalLabaRugi.Size = new Size(48, 22);
            lblNominalLabaRugi.TabIndex = 1;
            lblNominalLabaRugi.Text = "Rp 0";

            dgvLaporan.AllowUserToAddRows = false;
            dgvLaporan.AllowUserToDeleteRows = false;
            dgvLaporan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLaporan.BackgroundColor = SystemColors.ButtonFace;
            dgvLaporan.ColumnHeadersHeight = 34;
            dgvLaporan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvLaporan.Columns.AddRange(new DataGridViewColumn[] {
                colTanggal, colJenis, colKeterangan, colJumlah
            });
            dgvLaporan.EnableHeadersVisualStyles = false;
            dgvLaporan.Location = new Point(38, 219);
            dgvLaporan.Name = "dgvLaporan";
            dgvLaporan.RowHeadersVisible = false;
            dgvLaporan.RowHeadersWidth = 62;
            dgvLaporan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLaporan.MultiSelect = false;
            dgvLaporan.Size = new Size(898, 164);
            dgvLaporan.TabIndex = 10;

            colTanggal.HeaderText = "Tanggal";
            colTanggal.MinimumWidth = 8;
            colTanggal.Name = "colTanggal";

            colJenis.HeaderText = "Jenis";
            colJenis.MinimumWidth = 8;
            colJenis.Name = "colJenis";

            colKeterangan.HeaderText = "Keterangan";
            colKeterangan.MinimumWidth = 8;
            colKeterangan.Name = "colKeterangan";

            colJumlah.HeaderText = "Jumlah (Rp)";
            colJumlah.MinimumWidth = 8;
            colJumlah.Name = "colJumlah";

            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(dgvLaporan);
            Controls.Add(panelLabaRugi);
            Controls.Add(panel1);
            Controls.Add(panelPemasukan);
            Controls.Add(btnEksporExcel);
            Controls.Add(btnCetak);
            Controls.Add(btnTampilkan);
            Controls.Add(cmbKolam);
            Controls.Add(lblKolam);
            Controls.Add(cmbBulan);
            Controls.Add(lblBulan);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UcLaporan";
            Size = new Size(982, 429);

            panelPemasukan.ResumeLayout(false);
            panelPemasukan.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelLabaRugi.ResumeLayout(false);
            panelLabaRugi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLaporan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBulan;
        private ComboBox cmbBulan;
        private Label lblKolam;
        private ComboBox cmbKolam;
        private Button btnTampilkan;
        private Button btnCetak;
        private Button btnEksporExcel;
        private Panel panelPemasukan;
        private Label lblJudulPemasukan;
        private Label lblNominalPemasukan;
        private Panel panel1;
        private Label lblJudulPengeluaran;
        private Label lblNominalPengeluaran;
        private Panel panelLabaRugi;
        private Label lblNominalLabaRugi;
        private Label lblJudulLabaRugi;
        private DataGridView dgvLaporan;
        private DataGridViewTextBoxColumn colTanggal;
        private DataGridViewTextBoxColumn colJenis;
        private DataGridViewTextBoxColumn colKeterangan;
        private DataGridViewTextBoxColumn colJumlah;
    }
}
