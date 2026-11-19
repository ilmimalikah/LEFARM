using LEFARM.Model;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Data;
using System.Windows.Forms;

namespace LEFARM
{
    public partial class UcJadwalPakan : UserControl
    {
        private int _idJadwal = 0;

        public UcJadwalPakan()
        {
            InitializeComponent();

            dtpTanggal.Format = DateTimePickerFormat.Custom;
            dtpTanggal.CustomFormat = "dd-MM-yyyy";

            cbStatus.Text = "Belum";

            TampilData();
        }

        private void TampilData()
        {
            try
            {
                string query = @"SELECT j.id_jadwal, k.nama_kolam, j.tanggal, j.jam,
                                        j.jenis_pakan, j.jumlah_gram, j.status
                                 FROM jadwal_pakan j
                                 JOIN kolam k ON j.id_kolam = k.id_kolam
                                 ORDER BY j.tanggal, j.jam";
                DataTable dt = Koneksi.AmbilData(query);
                dataGridView1.DataSource = dt;

                if (dataGridView1.Columns.Contains("id_jadwal"))
                    dataGridView1.Columns["id_jadwal"].Visible = false;

                if (dataGridView1.Columns.Contains("nama_kolam"))
                    dataGridView1.Columns["nama_kolam"].HeaderText = "Nama Kolam";

                if (dataGridView1.Columns.Contains("tanggal"))
                    dataGridView1.Columns["tanggal"].DefaultCellStyle.Format = "dd-MM-yyyy";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        private int CariIdKolam(string namaKolam)
        {
            string aman = namaKolam.Trim().Replace("'", "''");
            DataTable dt = Koneksi.AmbilData(
                "SELECT id_kolam FROM kolam WHERE LOWER(nama_kolam) = LOWER('" + aman + "')");

            if (dt.Rows.Count == 0)
                throw new ArgumentException("Kolam \"" + namaKolam.Trim() + "\" tidak ditemukan di data kolam.");

            return Convert.ToInt32(dt.Rows[0]["id_kolam"]);
        }
        private JadwalPakan BuatObjek()
        {
            if (!TimeSpan.TryParse(txtJam.Text, out TimeSpan jam))
                throw new ArgumentException("Format jam salah. Contoh: 08:00");

            if (!int.TryParse(txtJumlahGram.Text, out int gram))
                throw new ArgumentException("Jumlah gram harus berupa angka.");

            JadwalPakan j = new JadwalPakan();
            j.NamaKolam = txtIdKolam.Text;
            j.IdKolam = CariIdKolam(j.NamaKolam);   
            j.Tanggal = dtpTanggal.Value.Date;
            j.Jam = jam;
            j.JenisPakan = txtJenisPakan.Text;
            j.JumlahGram = gram;
            j.StatusKerja = cbStatus.Text;
            return j;
        }

        private NpgsqlParameter[] BuatParameter(JadwalPakan j)
        {
            return new NpgsqlParameter[] {
                new NpgsqlParameter("@kolam", NpgsqlDbType.Integer) { Value = j.IdKolam },
                new NpgsqlParameter("@tgl", NpgsqlDbType.Date) { Value = j.Tanggal },
                new NpgsqlParameter("@jam", NpgsqlDbType.Time) { Value = j.Jam },
                new NpgsqlParameter("@pakan", NpgsqlDbType.Varchar) { Value = j.JenisPakan },
                new NpgsqlParameter("@gram", NpgsqlDbType.Integer) { Value = j.JumlahGram },
                new NpgsqlParameter("@status", NpgsqlDbType.Varchar) { Value = j.StatusKerja }
            };
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                JadwalPakan jadwal = BuatObjek();

                string query = "INSERT INTO jadwal_pakan (id_kolam, tanggal, jam, jenis_pakan, jumlah_gram, status) VALUES (@kolam, @tgl, @jam, @pakan, @gram, @status)";

                Koneksi.Jalankan(query, BuatParameter(jadwal));
                MessageBox.Show("Data berhasil disimpan!\n" + jadwal.Ringkasan());
                TampilData();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (_idJadwal == 0)
            {
                MessageBox.Show("Pilih data dulu dari tabel yang mau diubah.");
                return;
            }

            try
            {
                JadwalPakan jadwal = BuatObjek();

                string query = "UPDATE jadwal_pakan SET id_kolam=@kolam, tanggal=@tgl, jam=@jam, jenis_pakan=@pakan, jumlah_gram=@gram, status=@status WHERE id_jadwal=@id";

                NpgsqlParameter[] param = BuatParameter(jadwal);
                Array.Resize(ref param, param.Length + 1);
                param[param.Length - 1] = new NpgsqlParameter("@id", NpgsqlDbType.Integer) { Value = _idJadwal };

                Koneksi.Jalankan(query, param);
                MessageBox.Show("Data berhasil diubah!\n" + jadwal.Ringkasan());
                TampilData();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (_idJadwal == 0)
            {
                MessageBox.Show("Pilih data dulu dari tabel yang mau dihapus.");
                return;
            }

            DialogResult konfirmasi = MessageBox.Show(
                "Yakin ingin menghapus data ini?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (konfirmasi != DialogResult.Yes) return;

            try
            {
                string query = "DELETE FROM jadwal_pakan WHERE id_jadwal=@id";
                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@id", NpgsqlDbType.Integer) { Value = _idJadwal }
                };

                Koneksi.Jalankan(query, parameters);
                MessageBox.Show("Data berhasil dihapus!");
                TampilData();
                btnBersihkan_Click(null, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            _idJadwal = Convert.ToInt32(row.Cells["id_jadwal"].Value);

            txtIdKolam.Text = row.Cells["nama_kolam"].Value?.ToString() ?? "";

            if (row.Cells["tanggal"].Value != null &&
                DateTime.TryParse(row.Cells["tanggal"].Value.ToString(), out DateTime tgl))
            {
                dtpTanggal.Value = tgl;
            }

            object jamValue = row.Cells["jam"].Value;
            if (jamValue != null && TimeSpan.TryParse(jamValue.ToString(), out TimeSpan jam))
                txtJam.Text = jam.ToString(@"hh\:mm");
            else
                txtJam.Text = "";

            txtJenisPakan.Text = row.Cells["jenis_pakan"].Value?.ToString() ?? "";
            txtJumlahGram.Text = row.Cells["jumlah_gram"].Value?.ToString() ?? "";
            cbStatus.Text = row.Cells["status"].Value?.ToString() ?? "";
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            _idJadwal = 0;

            txtIdKolam.Clear();
            dtpTanggal.Value = DateTime.Now;
            txtJam.Clear();
            txtJenisPakan.Clear();
            txtJumlahGram.Clear();
            cbStatus.Text = "Belum";

            txtIdKolam.Focus();
        }
    }
}

namespace LEFARM.Model
{
    public class JadwalPakan : Jadwal
    {
        private string namaKolam;
        private string statusKerja = "Belum";
        private string jenisPakan;
        private int jumlahGram;

        public string NamaKolam
        {
            get { return namaKolam; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Nama kolam wajib diisi");
                }
                namaKolam = value.Trim();
            }
        }

        public string StatusKerja
        {
            get { return statusKerja; }
            set
            {
                if (value != "Belum" && value != "Proses" && value != "Selesai")
                {
                    throw new ArgumentException("Status harus Belum, Proses, atau Selesai");
                }
                statusKerja = value;
            }
        }

        public string JenisPakan
        {
            get { return jenisPakan; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Jenis pakan wajib diisi");
                }
                jenisPakan = value.Trim();
            }
        }

        public int JumlahGram
        {
            get { return jumlahGram; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Jumlah gram harus lebih dari 0");
                }
                jumlahGram = value;
            }
        }

        public override string AmbilJenis()
        {
            return "Pakan";
        }

        public override string Ringkasan()
        {
            return "Pakan " + JenisPakan + " " + JumlahGram + " gram untuk " + NamaKolam + " (" + StatusKerja + ")";
        }
    }
}