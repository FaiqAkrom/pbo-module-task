using System;

namespace PBO_RumahSakit.Main
{
    public class Orang
    {
        public string nama { get; set; }
        public int umur { get; set; }

        public Orang(string nama, int umur)
        {
            this.nama = nama;
            this.umur = umur;
        }

        public virtual void Aktivitas()
        {
            Console.WriteLine($"{nama} sedang melakukan pendaftaran di lobby untuk CT-Scan.");
        }

        public virtual void InfoOrang()
        {
            Console.WriteLine($"Nama: {nama}, Umur: {umur}");
        }
    }
}