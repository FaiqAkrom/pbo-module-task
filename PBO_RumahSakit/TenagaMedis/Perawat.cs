using System;

namespace PBO_RumahSakit.TenagaMedis
{
    public class Perawat : TenagaMedis
    {
        public Perawat(string nama, int umur, string spesialisasi) : base(nama, umur, spesialisasi) { }

        public void CekPasien()
        {
            Console.WriteLine($"Perawat {nama} sedang melakukan pengecekan kondisi vital pasien.");
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"Perawat {nama} sedang memberi assist operasional serta memberikan obat kepada pasien.");
        }
    }
}