using System;

namespace PBO_RumahSakit.Pasien
{
    public class PasienAnak : Pasien
    {
        public PasienAnak(string nama, int umur, string keluhan) : base(nama, umur, keluhan) { }

        public void Menangis()
        {
            Console.WriteLine($"{nama} nangis soalnya lagi sakit.");
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"{nama} sedang bermain di ruang tunggu anak.");
        }
    }
}