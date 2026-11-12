namespace LEFARM
{
    partial class UcJadwalPakan
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

        #region Component Designer generated code

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
            txtJenisPakan = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtJumlahGram = new TextBox();
            cbStatus = new ComboBox();
            label6 = new Label();
            btnSimpan = new Button();
            btnUbah = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            btnBersihkan = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtIdKolam
            // 
            txtIdKolam.Location = new Point(29, 56);
            txtIdKolam.Name = "txtIdKolam";
            txtIdKolam.Size = new Size(125, 27);
            txtIdKolam.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 33);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 1;
            label1.Text = "ID KOLAM";
            // 
            // txtJam
            // 
            txtJam.Location = new Point(419, 56);
            txtJam.Name = "txtJam";
            txtJam.Size = new Size(125, 27);
            txtJam.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(439, 33);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 3;
            label2.Text = "JAM";
            // 
            // dtpTanggal
            // 
            dtpTanggal.Location = new Point(163, 56);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(250, 27);
            dtpTanggal.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(173, 33);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 5;
            label3.Text = "TANGGAL";
            // 
            // txtJenisPakan
            // 
            txtJenisPakan.Location = new Point(550, 58);
            txtJenisPakan.Name = "txtJenisPakan";
            txtJenisPakan.Size = new Size(125, 27);
            txtJenisPakan.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(550, 35);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 7;
            label4.Text = "JENIS PAKAN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(681, 35);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 8;
            label5.Text = "JUMLAH GRAM";
            // 
            // txtJumlahGram
            // 
            txtJumlahGram.Location = new Point(681, 58);
            txtJumlahGram.Name = "txtJumlahGram";
            txtJumlahGram.Size = new Size(125, 27);
            txtJumlahGram.TabIndex = 9;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Belum Selesai", "Sedang Proses", "Selesai" });
            cbStatus.Location = new Point(812, 58);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(151, 28);
            cbStatus.TabIndex = 10;
            cbStatus.SelectedIndexChanged += cbStatus_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(812, 35);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 11;
            label6.Text = "STATUS";
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Silver;
            btnSimpan.Location = new Point(29, 120);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(128, 48);
            btnSimpan.TabIndex = 12;
            btnSimpan.Text = "SIMPAN";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnUbah
            // 
            btnUbah.BackColor = Color.Silver;
            btnUbah.Location = new Point(163, 120);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(119, 48);
            btnUbah.TabIndex = 13;
            btnUbah.Text = "UBAH";
            btnUbah.UseVisualStyleBackColor = false;
            btnUbah.Click += btnUbah_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Location = new Point(288, 120);
            button1.Name = "button1";
            button1.Size = new Size(116, 48);
            button1.TabIndex = 14;
            button1.Text = "HAPUS";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 202);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(903, 188);
            dataGridView1.TabIndex = 15;
            // 
            // btnBersihkan
            // 
            btnBersihkan.BackColor = Color.Silver;
            btnBersihkan.Location = new Point(410, 120);
            btnBersihkan.Name = "btnBersihkan";
            btnBersihkan.Size = new Size(125, 48);
            btnBersihkan.TabIndex = 16;
            btnBersihkan.Text = "BERSIHKAN";
            btnBersihkan.UseVisualStyleBackColor = false;
            btnBersihkan.Click += btnBersihkan_Click;
            // 
            // UcJadwalPakan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnBersihkan);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(btnUbah);
            Controls.Add(btnSimpan);
            Controls.Add(label6);
            Controls.Add(cbStatus);
            Controls.Add(txtJumlahGram);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtJenisPakan);
            Controls.Add(label3);
            Controls.Add(dtpTanggal);
            Controls.Add(label2);
            Controls.Add(txtJam);
            Controls.Add(label1);
            Controls.Add(txtIdKolam);
            Name = "UcJadwalPakan";
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
        private TextBox txtJenisPakan;
        private Label label4;
        private Label label5;
        private TextBox txtJumlahGram;
        private ComboBox cbStatus;
        private Label label6;
        private Button btnSimpan;
        private Button btnUbah;
        private Button button1;
        private DataGridView dataGridView1;
        private Button btnBersihkan;
    }
}
