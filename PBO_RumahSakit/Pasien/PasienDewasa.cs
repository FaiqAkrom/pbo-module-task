using System;

namespace PBO_RumahSakit.Pasien
{
    public class PasienDewasa : Pasien
    {
        public PasienDewasa(string nama, int umur, string keluhan) : base(nama, umur, keluhan) { }

        public void Konsultasi()
        {
            Console.WriteLine($"{nama} sedang bertemu dan melakukan konsultasi dengan dokter.");
        }
    }
}