// FILE: Model/Kolam.cs
using System;
using System.Data;
using Npgsql;

namespace LEFARM
{
    public class Kolam
    {
        // Data disimpan private (enkapsulasi)
        private int idKolam;
        private string namaKolam = "";
        private string ukuran = "";

        // Property: pintu untuk membaca dan mengisi data
        public int IdKolam
        {
            get { return idKolam; }
            set { idKolam = value; }
        }

        public string NamaKolam
        {
            get { return namaKolam; }
            set { namaKolam = value.Trim(); }
        }

        public string Ukuran
        {
            get { return ukuran; }
            set { ukuran = value.Trim(); }
        }

        // Memeriksa isian. Kalau ada yang kosong, lempar pesan error.
        private void PeriksaData()
        {
            if (namaKolam == "" || ukuran == "")
            {
                throw new ArgumentException("Semua kolom wajib diisi");
            }
        }

        // Melihat data kolam
        public DataTable LihatDataKolam()
        {
            return Koneksi.AmbilData(
                "SELECT id_kolam, nama_kolam, ukuran FROM kolam ORDER BY id_kolam");
        }

        // Menambah data kolam
        public void TambahDataKolam()
        {
            PeriksaData();

            Koneksi.Jalankan(
                "INSERT INTO kolam (nama_kolam, ukuran) VALUES (@nama, @ukuran)",
                new NpgsqlParameter("@nama", namaKolam),
                new NpgsqlParameter("@ukuran", ukuran));
        }

        // Mengubah data kolam
        public void UbahDataKolam()
        {
            PeriksaData();

            Koneksi.Jalankan(
                "UPDATE kolam SET nama_kolam = @nama, ukuran = @ukuran WHERE id_kolam = @id",
                new NpgsqlParameter("@nama", namaKolam),
                new NpgsqlParameter("@ukuran", ukuran),
                new NpgsqlParameter("@id", idKolam));
        }

        // Menghapus data kolam
        public void HapusDataKolam()
        {
            Koneksi.Jalankan(
                "DELETE FROM kolam WHERE id_kolam = @id",
                new NpgsqlParameter("@id", idKolam));
        }
    }
}