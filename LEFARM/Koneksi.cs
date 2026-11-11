using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LEFARM
{
    public class Koneksi
    {
        private static string alamat =
            "Host=localhost;Port=5432;Username=postgres;Password=stillwithyou;Database=LEFARM";

        public static NpgsqlConnection BuatKoneksi()
        {
            return new NpgsqlConnection(alamat);
        }

        public static DataTable AmbilData(string sql)
        {
            DataTable tabel = new DataTable();
            using (NpgsqlConnection conn = BuatKoneksi())
            {
                conn.Open();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, conn);
                adapter.Fill(tabel);
            }
            return tabel;
        }

        public static void Jalankan(string sql, params NpgsqlParameter[] parameter)
        {
            using (NpgsqlConnection conn = BuatKoneksi())
            {
                conn.Open();
                NpgsqlCommand perintah = new NpgsqlCommand(sql, conn);
                perintah.Parameters.AddRange(parameter);
                perintah.ExecuteNonQuery();
            }
        }

        public static bool TesKoneksi()
        {
            try
            {
                using (NpgsqlConnection conn = BuatKoneksi())
                {
                    conn.Open();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
