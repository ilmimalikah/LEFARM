namespace LEFARM
{
    partial class UcBeranda
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
            panel1 = new Panel();
            label1 = new Label();
            lblTotalPemasukan = new Label();
            panel2 = new Panel();
            lblTotalPengeluaran = new Label();
            label3 = new Label();
            panel3 = new Panel();
            lblLabaBersih = new Label();
            label4 = new Label();
            panel4 = new Panel();
            lblTotalPanen = new Label();
            label5 = new Label();
            label2 = new Label();
            dgvJadwal = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJadwal).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblTotalPemasukan);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(20, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 80);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 0;
            label1.Text = "Total Pemasukan";
            // 
            // lblTotalPemasukan
            // 
            lblTotalPemasukan.AutoSize = true;
            lblTotalPemasukan.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPemasukan.Location = new Point(10, 38);
            lblTotalPemasukan.Name = "lblTotalPemasukan";
            lblTotalPemasukan.Size = new Size(62, 31);
            lblTotalPemasukan.TabIndex = 1;
            lblTotalPemasukan.Text = "Rp 0";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblTotalPengeluaran);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(255, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 80);
            panel2.TabIndex = 2;
            // 
            // lblTotalPengeluaran
            // 
            lblTotalPengeluaran.AutoSize = true;
            lblTotalPengeluaran.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPengeluaran.Location = new Point(10, 38);
            lblTotalPengeluaran.Name = "lblTotalPengeluaran";
            lblTotalPengeluaran.Size = new Size(62, 31);
            lblTotalPengeluaran.TabIndex = 1;
            lblTotalPengeluaran.Text = "Rp 0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 10);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 0;
            label3.Text = "Total Pengeluaran";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblLabaBersih);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(490, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(220, 80);
            panel3.TabIndex = 3;
            // 
            // lblLabaBersih
            // 
            lblLabaBersih.AutoSize = true;
            lblLabaBersih.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLabaBersih.Location = new Point(10, 38);
            lblLabaBersih.Name = "lblLabaBersih";
            lblLabaBersih.Size = new Size(62, 31);
            lblLabaBersih.TabIndex = 1;
            lblLabaBersih.Text = "Rp 0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 10);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 0;
            label4.Text = "Laba Bersih";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblTotalPanen);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(725, 20);
            panel4.Name = "panel4";
            panel4.Size = new Size(220, 80);
            panel4.TabIndex = 4;
            // 
            // lblTotalPanen
            // 
            lblTotalPanen.AutoSize = true;
            lblTotalPanen.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPanen.Location = new Point(10, 38);
            lblTotalPanen.Name = "lblTotalPanen";
            lblTotalPanen.Size = new Size(62, 31);
            lblTotalPanen.TabIndex = 1;
            lblTotalPanen.Text = "Rp 0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 10);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 0;
            label5.Text = "Laba Bersih";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 120);
            label2.Name = "label2";
            label2.Size = new Size(247, 20);
            label2.TabIndex = 5;
            label2.Text = "Jadwal Belum Selesai (5 Terdekat)";
            // 
            // dgvJadwal
            // 
            dgvJadwal.AllowUserToAddRows = false;
            dgvJadwal.AllowUserToDeleteRows = false;
            dgvJadwal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJadwal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJadwal.Location = new Point(20, 145);
            dgvJadwal.MultiSelect = false;
            dgvJadwal.Name = "dgvJadwal";
            dgvJadwal.ReadOnly = true;
            dgvJadwal.RowHeadersVisible = false;
            dgvJadwal.RowHeadersWidth = 51;
            dgvJadwal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJadwal.Size = new Size(940, 250);
            dgvJadwal.TabIndex = 6;
            // 
            // UcBeranda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dgvJadwal);
            Controls.Add(label2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UcBeranda";
            Size = new Size(982, 429);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJadwal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTotalPemasukan;
        private Label label1;
        private Panel panel2;
        private Label lblTotalPengeluaran;
        private Label label3;
        private Panel panel3;
        private Label lblLabaBersih;
        private Label label4;
        private Panel panel4;
        private Label lblTotalPanen;
        private Label label5;
        private Label label2;
        private DataGridView dgvJadwal;
    }
}