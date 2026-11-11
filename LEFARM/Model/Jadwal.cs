using System;
using System.Collections.Generic;
using System.Text;

namespace LEFARM.Model
{
    public abstract class Jadwal
    {
        private int idKolam;
        private DateTime tanggal = DateTime.Today;
        private TimeSpan jam = new TimeSpan(8, 0, 0);
        private string status = "Belum";

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

        public TimeSpan Jam
        {
            get { return jam; }
            set { jam = value; }
        }

        public string Status
        {
            get { return status; }
            set
            {
                if (value != "Belum" && value != "Selesai")
                {
                    throw new ArgumentException("Status harus Belum atau Selesai");
                }
                status = value;
            }
        }

        public abstract string AmbilJenis();
        public abstract string Ringkasan();
    }
}
