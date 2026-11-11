using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace LEFARM
{
    public partial class UcJadwalPengurasan : UserControl
    {
        public UcJadwalPengurasan()
        {
            InitializeComponent();
            TampilData();
        }

        private void TampilData()
        {
            try
            {
                string query = "SELECT * FROM jadwal_pengurasan";
                DataTable dt = Koneksi.AmbilData(query);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO jadwal_pengurasan (id_kolam, tanggal, jam, metode, status) VALUES (@kolam, @tgl, @jam, @metode, @status)";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@kolam", txtIdKolam.Text),
                    new NpgsqlParameter("@tgl", dtpTanggal.Value),
                    new NpgsqlParameter("@jam", TimeSpan.Parse(txtJam.Text)),
                    new NpgsqlParameter("@metode", cbMetode.Text),
                    new NpgsqlParameter("@status", cbStatus.Text)
                };

                Koneksi.Jalankan(query, parameters);
                MessageBox.Show("Data pengurasan berhasil disimpan!");
                TampilData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE jadwal_pengurasan SET tanggal=@tgl, jam=@jam, metode=@metode, status=@status WHERE id_kolam=@kolam";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@kolam", txtIdKolam.Text),
                    new NpgsqlParameter("@tgl", dtpTanggal.Value),
                    new NpgsqlParameter("@jam", TimeSpan.Parse(txtJam.Text)),
                    new NpgsqlParameter("@metode", cbMetode.Text),
                    new NpgsqlParameter("@status", cbStatus.Text)
                };

                Koneksi.Jalankan(query, parameters);
                MessageBox.Show("Data pengurasan berhasil diubah!");
                TampilData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM jadwal_pengurasan WHERE id_kolam=@kolam";
                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@kolam", txtIdKolam.Text)
                };

                Koneksi.Jalankan(query, parameters);
                MessageBox.Show("Data pengurasan berhasil dihapus!");
                TampilData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtIdKolam.Text = row.Cells["id_kolam"].Value?.ToString() ?? "";

                if (row.Cells["tanggal"].Value != null && DateTime.TryParse(row.Cells["tanggal"].Value.ToString(), out DateTime tgl))
                {
                    dtpTanggal.Value = tgl;
                }

                txtJam.Text = row.Cells["jam"].Value?.ToString() ?? "";
                cbMetode.Text = row.Cells["metode"].Value?.ToString() ?? "";
                cbStatus.Text = row.Cells["status"].Value?.ToString() ?? "";
            }
        }
    }
}