namespace LEFARM
{
    partial class FormLogin
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
            lblJudul = new Label();
            lblSubjudul = new Label();
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new MaskedTextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.Location = new Point(415, 123);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(150, 46);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "LEFARM";
            // 
            // lblSubjudul
            // 
            lblSubjudul.AutoSize = true;
            lblSubjudul.Location = new Point(361, 169);
            lblSubjudul.Name = "lblSubjudul";
            lblSubjudul.Size = new Size(254, 20);
            lblSubjudul.TabIndex = 1;
            lblSubjudul.Text = "Manajemen Keuangan Budidaya Lele";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(361, 216);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(361, 291);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(361, 239);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(254, 27);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(361, 314);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(254, 27);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SeaGreen;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(431, 386);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // FormLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblSubjudul);
            Controls.Add(lblJudul);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LEFARM - Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJudul;
        private Label lblSubjudul;
        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private MaskedTextBox txtPassword;
        private Button btnLogin;
    }
}