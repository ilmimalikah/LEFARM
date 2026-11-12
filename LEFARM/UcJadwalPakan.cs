using LEFARM.Model;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace LEFARM
{
    public partial class UcJadwalPakan : UserControl
    {
        public UcJadwalPakan()
        {
            InitializeComponent();
            TampilData();
        }

        private void TampilData()
        {
            try
            {
                string query = "SELECT * FROM jadwal_pakan";
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
                string query = "INSERT INTO jadwal_pakan (id_kolam, tanggal, jam, jenis_pakan, jumlah_gram, status) VALUES (@kolam, @tgl, @jam, @pakan, @gram, @status)";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@kolam", txtIdKolam.Text),
                    new NpgsqlParameter("@tgl", dtpTanggal.Value),
                    new NpgsqlParameter("@jam", TimeSpan.Parse(txtJam.Text)),
                    new NpgsqlParameter("@pakan", txtJenisPakan.Text),
                    new NpgsqlParameter("@gram", Convert.ToInt32(txtJumlahGram.Text)),
                    new NpgsqlParameter("@status", cbStatus.Text)
                };

                Koneksi.Jalankan(query, parameters);
                MessageBox.Show("Data berhasil disimpan!");
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
                string query = "UPDATE jadwal_pakan SET tanggal=@tgl, jam=@jam, jenis_pakan=@pakan, jumlah_gram=@gram, status=@status WHERE id_kolam=@kolam";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@kolam", txtIdKolam.Text),
                    new NpgsqlParameter("@tgl", dtpTanggal.Value),
                    new NpgsqlParameter("@jam", TimeSpan.Parse(txtJam.Text)),
                    new NpgsqlParameter("@pakan", txtJenisPakan.Text),
                    new NpgsqlParameter("@gram", Convert.ToInt32(txtJumlahGram.Text)),
                    new NpgsqlParameter("@status", cbStatus.Text)
                };

                Koneksi.Jalankan(query, parameters);
                MessageBox.Show("Data berhasil diubah!");
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
                string query = "DELETE FROM jadwal_pakan WHERE id_kolam=@kolam";
                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@kolam", txtIdKolam.Text)
                };

                Koneksi.Jalankan(query, parameters);
                MessageBox.Show("Data berhasil dihapus!");
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
                txtJenisPakan.Text = row.Cells["jenis_pakan"].Value?.ToString() ?? "";
                txtJumlahGram.Text = row.Cells["jumlah_gram"].Value?.ToString() ?? "";
                cbStatus.Text = row.Cells["status"].Value?.ToString() ?? "";
            }
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            txtIdKolam.Clear();
            dtpTanggal.Value = DateTime.Now;
            txtJam.Clear();
            txtJenisPakan.Clear();
            txtJumlahGram.Clear();
            cbStatus.SelectedIndex = -1;

            txtIdKolam.Focus();
        }
    }
}