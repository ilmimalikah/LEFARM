using LEFARM.Model;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Data;
using System.Windows.Forms;

namespace LEFARM
{
    public partial class UcJadwalPengurasan : UserControl
    {
        private int _idJadwal = 0;

        public UcJadwalPengurasan()
        {
            InitializeComponent();

            dtpTanggal.Format = DateTimePickerFormat.Custom;
            dtpTanggal.CustomFormat = "dd-MM-yyyy";

            cbStatus.Text = "Belum";
            cbKolam.DropDownStyle = ComboBoxStyle.DropDownList;

            dataGridView1.Enabled = true;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.BackgroundColor = System.Drawing.Color.White;

            dataGridView1.CellClick -= dataGridView1_CellClick;
            dataGridView1.CellClick += dataGridView1_CellClick;

            this.VisibleChanged += (s, e) => { if (this.Visible) MuatKolam(); };
            cbKolam.Enter += (s, e) => MuatKolam();

            MuatKolam();
            TampilData();
        }

        private void MuatKolam()
        {
            try
            {
                object terpilih = cbKolam.SelectedValue;

                DataTable dt = Koneksi.AmbilData("SELECT id_kolam, nama_kolam FROM kolam ORDER BY nama_kolam");
                cbKolam.DataSource = dt;
                cbKolam.DisplayMember = "nama_kolam";
                cbKolam.ValueMember = "id_kolam";

                if (terpilih != null)
                    cbKolam.SelectedValue = terpilih;
                else
                    cbKolam.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat daftar kolam: " + ex.Message);
            }
        }

        private void TampilData()
        {
            try
            {
                string query = @"SELECT j.id_jadwal, k.nama_kolam, j.tanggal, j.jam,
                                        j.keterangan, j.status
                                 FROM jadwal_pengurasan j
                                 JOIN kolam k ON j.id_kolam = k.id_kolam
                                 ORDER BY j.tanggal, j.jam";
                DataTable dt = Koneksi.AmbilData(query);
                dataGridView1.DataSource = dt;

                dataGridView1.Columns["id_jadwal"].Visible = false;

                dataGridView1.Columns["nama_kolam"].HeaderText = "Nama Kolam";
                dataGridView1.Columns["tanggal"].HeaderText = "Tanggal";
                dataGridView1.Columns["jam"].HeaderText = "Jam";
                dataGridView1.Columns["keterangan"].HeaderText = "Keterangan";
                dataGridView1.Columns["status"].HeaderText = "Status";

                dataGridView1.Columns["tanggal"].DefaultCellStyle.Format = "dd-MM-yyyy";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        private JadwalPengurasan BuatObjek()
        {
            if (cbKolam.SelectedValue == null)
                throw new ArgumentException("Nama kolam wajib dipilih.");

            if (!TimeSpan.TryParse(txtJam.Text, out TimeSpan jam))
                throw new ArgumentException("Format jam salah. Contoh: 08:00");

            JadwalPengurasan j = new JadwalPengurasan();
            j.NamaKolam = cbKolam.Text;
            j.IdKolam = Convert.ToInt32(cbKolam.SelectedValue);   
            j.Tanggal = dtpTanggal.Value.Date;
            j.Jam = jam;
            j.Keterangan = cbMetode.Text;
            j.StatusKerja = cbStatus.Text;
            return j;
        }

        private NpgsqlParameter[] BuatParameter(JadwalPengurasan j)
        {
            return new NpgsqlParameter[] {
                new NpgsqlParameter("@kolam", NpgsqlDbType.Integer) { Value = j.IdKolam },
                new NpgsqlParameter("@tgl", NpgsqlDbType.Date) { Value = j.Tanggal },
                new NpgsqlParameter("@jam", NpgsqlDbType.Time) { Value = j.Jam },
                new NpgsqlParameter("@ket", NpgsqlDbType.Varchar) { Value = j.Keterangan },
                new NpgsqlParameter("@status", NpgsqlDbType.Varchar) { Value = j.StatusKerja }
            };
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                JadwalPengurasan jadwal = BuatObjek();

                string query = "INSERT INTO jadwal_pengurasan (id_kolam, tanggal, jam, keterangan, status) VALUES (@kolam, @tgl, @jam, @ket, @status)";

                Koneksi.Jalankan(query, BuatParameter(jadwal));
                MessageBox.Show("Data pengurasan berhasil disimpan!\n" + jadwal.Ringkasan());
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
                JadwalPengurasan jadwal = BuatObjek();

                string query = "UPDATE jadwal_pengurasan SET id_kolam=@kolam, tanggal=@tgl, jam=@jam, keterangan=@ket, status=@status WHERE id_jadwal=@id";

                NpgsqlParameter[] param = BuatParameter(jadwal);
                Array.Resize(ref param, param.Length + 1);
                param[param.Length - 1] = new NpgsqlParameter("@id", NpgsqlDbType.Integer) { Value = _idJadwal };

                Koneksi.Jalankan(query, param);
                MessageBox.Show("Data pengurasan berhasil diubah!\n" + jadwal.Ringkasan());
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
                string query = "DELETE FROM jadwal_pengurasan WHERE id_jadwal=@id";
                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@id", NpgsqlDbType.Integer) { Value = _idJadwal }
                };

                Koneksi.Jalankan(query, parameters);
                MessageBox.Show("Data pengurasan berhasil dihapus!");
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

            string namaKolam = row.Cells["nama_kolam"].Value?.ToString() ?? "";
            cbKolam.SelectedIndex = cbKolam.FindStringExact(namaKolam);

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

            cbMetode.Text = row.Cells["keterangan"].Value?.ToString() ?? "";
            cbStatus.Text = row.Cells["status"].Value?.ToString() ?? "";
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            _idJadwal = 0;

            cbKolam.SelectedIndex = -1;
            dtpTanggal.Value = DateTime.Now;
            txtJam.Clear();
            cbMetode.SelectedIndex = -1;
            cbStatus.Text = "Belum";

            cbKolam.Focus();
        }
    }
}

namespace LEFARM.Model
{
    public class JadwalPengurasan : Jadwal
    {
        private string namaKolam;
        private string statusKerja = "Belum";
        private string keterangan;

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

        public string Keterangan
        {
            get { return keterangan; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Keterangan wajib diisi");
                }
                keterangan = value.Trim();
            }
        }

        public override string AmbilJenis()
        {
            return "Pengurasan";
        }

        public override string Ringkasan()
        {
            return "Pengurasan " + NamaKolam + ": " + Keterangan + " (" + StatusKerja + ")";
        }
    }
}