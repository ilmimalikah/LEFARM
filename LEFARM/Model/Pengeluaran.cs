
using System;

namespace LEFARM.Model
{
    public class Pengeluaran : Transaksi
    {
        public Pengeluaran(int idKolam, DateTime tanggal,
                           string keterangan, decimal jumlah)
        {
            IdKolam = idKolam;
            Tanggal = tanggal;
            Keterangan = keterangan;
            Jumlah = jumlah;
        }

        public override decimal HitungNilai()
        {
            return Jumlah;
        }

        public override string AmbilJenis()
        {
            return "Pengeluaran";
        }
    }
}
