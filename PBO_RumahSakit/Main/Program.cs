using System;
using PBO_RumahSakit.Main;
using PBO_RumahSakit.Pasien;
using PBO_RumahSakit.TenagaMedis;

namespace PBO_RumahSakit.Main
{
    class Program
    {
        static void Main(string[] args)
        {

            RumahSakit rs = new RumahSakit();
            Dokter drSpesialis = new Dokter("Dr.Mario", 45, "Bedah Rumah");
            Perawat suster = new Perawat("Suster Radit", 28, "IGD");
            PasienAnak anak = new PasienAnak("Osama", 8, "Demam Duit");
            PasienDewasa dewasa = new PasienDewasa("Pak Arlan", 50, "Asam asaman");

            rs.TambahOrang(drSpesialis);
            rs.TambahOrang(suster);
            rs.TambahOrang(anak);
            rs.TambahOrang(dewasa);
            rs.DaftarOrang();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n | Demonstrasi Method Khusus |   ");
            drSpesialis.Diagnosa();
            suster.CekPasien();
            anak.Menangis();
            dewasa.Konsultasi();
        }
    }
}
