using System;
using PBO_RumahSakit.Main;

namespace PBO_RumahSakit.TenagaMedis
{
    public class TenagaMedis : Orang
    {
        public string spesialisasi { get; set; }

        public TenagaMedis(string nama, int umur, string spesialisasi) : base(nama, umur)
        {
            this.spesialisasi = spesialisasi;
        }

        public void CekSpesialis()
        {
            Console.WriteLine($"Spesialisasi {nama}: {spesialisasi}");
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"{nama} sedang bersiap melayani pasien.");
        }
    }
}