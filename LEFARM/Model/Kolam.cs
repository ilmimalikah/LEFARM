using System;
using System.Collections.Generic;
using System.Text;

namespace LEFARM.Model
{
    public class Kolam
    {
        private int idKolam;
        private string namaKolam = "";
        private string ukuran = "";
        private int jumlahBibit;
        private DateTime tanggalTebar = DateTime.Today;

        public int IdKolam
        {
            get { return idKolam; }
            set { idKolam = value; }
        }

        public string NamaKolam
        {
            get { return namaKolam; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Semua kolom wajib diisi");
                }
                namaKolam = value.Trim();
            }
        }

        public string Ukuran
        {
            get { return ukuran; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Semua kolom wajib diisi");
                }
                ukuran = value.Trim();
            }
        }

        public int JumlahBibit
        {
            get { return jumlahBibit; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Jumlah bibit harus lebih dari 0");
                }
                jumlahBibit = value;
            }
        }

        public DateTime TanggalTebar
        {
            get { return tanggalTebar; }
            set { tanggalTebar = value; }
        }
    }
}
