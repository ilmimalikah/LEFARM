namespace LEFARM
{
    partial class UcJadwalPengurasan
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
            txtIdKolam = new TextBox();
            label1 = new Label();
            txtJam = new TextBox();
            label2 = new Label();
            dtpTanggal = new DateTimePicker();
            label3 = new Label();
            cbMetode = new ComboBox();
            label4 = new Label();
            cbStatus = new ComboBox();
            label5 = new Label();
            btnSimpan = new Button();
            btnUbah = new Button();
            btnHapus = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtIdKolam
            // 
            txtIdKolam.Location = new Point(27, 58);
            txtIdKolam.Name = "txtIdKolam";
            txtIdKolam.Size = new Size(125, 27);
            txtIdKolam.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 35);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 1;
            label1.Text = "ID KOLAM";
            // 
            // txtJam
            // 
            txtJam.Location = new Point(27, 192);
            txtJam.Name = "txtJam";
            txtJam.Size = new Size(125, 27);
            txtJam.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 169);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 3;
            label2.Text = "JAM";
            // 
            // dtpTanggal
            // 
            dtpTanggal.Location = new Point(27, 123);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(250, 27);
            dtpTanggal.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 100);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 5;
            label3.Text = "TANGGAL";
            // 
            // cbMetode
            // 
            cbMetode.FormattingEnabled = true;
            cbMetode.Items.AddRange(new object[] { "Kuras Total", "Kuras Sebagian" });
            cbMetode.Location = new Point(27, 262);
            cbMetode.Name = "cbMetode";
            cbMetode.Size = new Size(151, 28);
            cbMetode.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 239);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 7;
            label4.Text = "KETERANGAN";
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Belum Selesai", "Sedang Proses", "Selesai" });
            cbStatus.Location = new Point(27, 325);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(151, 28);
            cbStatus.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 302);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 9;
            label5.Text = "STATUS";
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Lime;
            btnSimpan.Location = new Point(27, 382);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 10;
            btnSimpan.Text = "SIMPAN";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnUbah
            // 
            btnUbah.BackColor = Color.Yellow;
            btnUbah.Location = new Point(153, 382);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(94, 29);
            btnUbah.TabIndex = 11;
            btnUbah.Text = "UBAH";
            btnUbah.UseVisualStyleBackColor = false;
            btnUbah.Click += btnUbah_Click;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.Red;
            btnHapus.Location = new Point(289, 382);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(94, 29);
            btnHapus.TabIndex = 12;
            btnHapus.Text = "HAPUS";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(556, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 13;
            // 
            // UcJadwalPengurasan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(btnHapus);
            Controls.Add(btnUbah);
            Controls.Add(btnSimpan);
            Controls.Add(label5);
            Controls.Add(cbStatus);
            Controls.Add(label4);
            Controls.Add(cbMetode);
            Controls.Add(label3);
            Controls.Add(dtpTanggal);
            Controls.Add(label2);
            Controls.Add(txtJam);
            Controls.Add(label1);
            Controls.Add(txtIdKolam);
            Name = "UcJadwalPengurasan";
            Size = new Size(982, 429);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdKolam;
        private Label label1;
        private TextBox txtJam;
        private Label label2;
        private DateTimePicker dtpTanggal;
        private Label label3;
        private ComboBox cbMetode;
        private Label label4;
        private ComboBox cbStatus;
        private Label label5;
        private Button btnSimpan;
        private Button btnUbah;
        private Button btnHapus;
        private DataGridView dataGridView1;
    }
}