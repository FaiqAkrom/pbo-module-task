using System;

namespace PBO_RumahSakit.TenagaMedis
{
    public class Dokter : TenagaMedis
    {
        public Dokter(string nama, int umur, string spesialisasi) : base(nama, umur, spesialisasi) { }

        public void Diagnosa()
        {
            Console.WriteLine($"Dokter {nama} sedang melakukan diagnosa kepada pasien.");
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"Dokter {nama} sedang melakukan visit ke tempat tinggal pasien.");
        }

        public override void InfoOrang()
        {
            base.InfoOrang();
            Console.WriteLine($"Spesialisasi: {spesialisasi}");
        }
    }
}