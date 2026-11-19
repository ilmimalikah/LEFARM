namespace LEFARM
{
    partial class UcKolam
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNamaKolam = new TextBox();
            txtUkuran = new TextBox();
            nudJumlahBibit = new NumericUpDown();
            dtpTanggalTebar = new DateTimePicker();
            btnTambah = new Button();
            btnUbah = new Button();
            btnHapus = new Button();
            btnBersihkan = new Button();
            dgvKolam = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudJumlahBibit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKolam).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 0;
            label1.Text = "Nama Kolam";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(275, 25);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 1;
            label2.Text = "Ukuran";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(475, 25);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 2;
            label3.Text = "Jumlah Bibit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(650, 25);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 25);
            label4.TabIndex = 3;
            label4.Text = "Tanggal Tebar";
            // 
            // txtNamaKolam
            // 
            txtNamaKolam.Location = new Point(25, 52);
            txtNamaKolam.Margin = new Padding(4, 4, 4, 4);
            txtNamaKolam.Name = "txtNamaKolam";
            txtNamaKolam.Size = new Size(224, 31);
            txtNamaKolam.TabIndex = 4;
            // 
            // txtUkuran
            // 
            txtUkuran.Location = new Point(275, 52);
            txtUkuran.Margin = new Padding(4, 4, 4, 4);
            txtUkuran.Name = "txtUkuran";
            txtUkuran.Size = new Size(174, 31);
            txtUkuran.TabIndex = 5;
            // 
            // nudJumlahBibit
            // 
            nudJumlahBibit.Location = new Point(475, 52);
            nudJumlahBibit.Margin = new Padding(4, 4, 4, 4);
            nudJumlahBibit.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudJumlahBibit.Name = "nudJumlahBibit";
            nudJumlahBibit.Size = new Size(150, 31);
            nudJumlahBibit.TabIndex = 6;
            // 
            // dtpTanggalTebar
            // 
            dtpTanggalTebar.CustomFormat = "dd/MM/yyyy";
            dtpTanggalTebar.Format = DateTimePickerFormat.Custom;
            dtpTanggalTebar.Location = new Point(650, 52);
            dtpTanggalTebar.Margin = new Padding(4, 4, 4, 4);
            dtpTanggalTebar.Name = "dtpTanggalTebar";
            dtpTanggalTebar.Size = new Size(186, 31);
            dtpTanggalTebar.TabIndex = 7;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(25, 100);
            btnTambah.Margin = new Padding(4, 4, 4, 4);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(125, 40);
            btnTambah.TabIndex = 8;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            // 
            // btnUbah
            // 
            btnUbah.Location = new Point(162, 100);
            btnUbah.Margin = new Padding(4, 4, 4, 4);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(125, 40);
            btnUbah.TabIndex = 9;
            btnUbah.Text = "Ubah";
            btnUbah.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(300, 100);
            btnHapus.Margin = new Padding(4, 4, 4, 4);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(125, 40);
            btnHapus.TabIndex = 10;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnBersihkan
            // 
            btnBersihkan.Location = new Point(438, 100);
            btnBersihkan.Margin = new Padding(4, 4, 4, 4);
            btnBersihkan.Name = "btnBersihkan";
            btnBersihkan.Size = new Size(125, 40);
            btnBersihkan.TabIndex = 11;
            btnBersihkan.Text = "Clear";
            btnBersihkan.UseVisualStyleBackColor = true;
            // 
            // dgvKolam
            // 
            dgvKolam.AllowUserToAddRows = false;
            dgvKolam.AllowUserToDeleteRows = false;
            dgvKolam.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKolam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKolam.Location = new Point(25, 162);
            dgvKolam.Margin = new Padding(4, 4, 4, 4);
            dgvKolam.Name = "dgvKolam";
            dgvKolam.ReadOnly = true;
            dgvKolam.RowHeadersVisible = false;
            dgvKolam.RowHeadersWidth = 51;
            dgvKolam.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKolam.Size = new Size(1150, 350);
            dgvKolam.TabIndex = 12;
            // 
            // UcKolam
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvKolam);
            Controls.Add(btnBersihkan);
            Controls.Add(btnHapus);
            Controls.Add(btnUbah);
            Controls.Add(btnTambah);
            Controls.Add(dtpTanggalTebar);
            Controls.Add(nudJumlahBibit);
            Controls.Add(txtUkuran);
            Controls.Add(txtNamaKolam);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "UcKolam";
            Size = new Size(1228, 536);
            Load += UcKolam_Load_1;
            ((System.ComponentModel.ISupportInitialize)nudJumlahBibit).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKolam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNamaKolam;
        private TextBox txtUkuran;
        private NumericUpDown nudJumlahBibit;
        private DateTimePicker dtpTanggalTebar;
        private Button btnTambah;
        private Button btnUbah;
        private Button btnHapus;
        private Button btnBersihkan;
        private DataGridView dgvKolam;
    }
}