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
            txtNamaKolam = new TextBox();
            txtUkuran = new TextBox();
            btnTambah = new Button();
            btnUbah = new Button();
            btnHapus = new Button();
            btnBersihkan = new Button();
            dgvKolam = new DataGridView();
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
            Controls.Add(txtUkuran);
            Controls.Add(txtNamaKolam);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "UcKolam";
            Size = new Size(982, 429);
            ((System.ComponentModel.ISupportInitialize)dgvKolam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNamaKolam;
        private TextBox txtUkuran;
        private Button btnTambah;
        private Button btnUbah;
        private Button btnHapus;
        private Button btnBersihkan;
        private DataGridView dgvKolam;
    }
}