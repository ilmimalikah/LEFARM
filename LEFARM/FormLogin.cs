namespace LEFARM
{
    public partial class FormLogin : Form
    {
        private const string UsernameBenar = "admin";
        private const string PasswordBenar = "admin123";

        public FormLogin()
        {
            InitializeComponent();
            btnLogin.Click += btnLogin_Click;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == UsernameBenar && txtPassword.Text == PasswordBenar)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Username atau password salah");
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }
    }
}