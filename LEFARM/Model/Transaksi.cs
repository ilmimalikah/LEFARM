using System;
using System.Collections.Generic;
using System.Text;

namespace LEFARM.Model
{
    public abstract class Transaksi
    {
        private int idKolam;
        private DateTime tanggal = DateTime.Today;
        private string keterangan = "";
        private decimal jumlah;

        public int IdKolam
        {
            get { return idKolam; }
            set { idKolam = value; }
        }

        public DateTime Tanggal
        {
            get { return tanggal; }
            set { tanggal = value; }
        }

        public string Keterangan
        {
            get { return keterangan; }
            set { keterangan = value; }
        }

        public decimal Jumlah
        {
            get { return jumlah; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Jumlahnya tidak boleh negatif");
                }
                jumlah = value;
            }
        }

        public abstract decimal HitungNilai();
        public abstract string AmbilJenis();
    }
}
