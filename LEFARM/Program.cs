using System;
using System.Windows.Forms;

namespace LEFARM
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            if (!Koneksi.TesKoneksi())
            {
                return;
            }

            FormLogin login = new FormLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FormUtama());
            }
        }
    }
}