using System;
using PBO_RumahSakit.Main;

namespace PBO_RumahSakit.Pasien
{
    public class Pasien : Orang
    {
        public string keluhan { get; set; }

        public Pasien(string nama, int umur, string keluhan) : base(nama, umur)
        {
            this.keluhan = keluhan;
        }

        public void CekKeluhan()
        {
            Console.WriteLine($"Keluhan {nama}: {keluhan}");
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"{nama} sedang menunggu hasil lab dari rumah sakit.");
        }
    }
}