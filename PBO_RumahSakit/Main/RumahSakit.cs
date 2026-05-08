using System;
using System.Collections.Generic;

namespace PBO_RumahSakit.Main
{
    public class RumahSakit
    {
        private List<Orang> daftarOrang = new List<Orang>();

        public void TambahOrang(Orang orang)
        {
            daftarOrang.Add(orang);
        }

        public void DaftarOrang()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" | Daftar Orang di Rumah Sakit |");
            foreach (var orang in daftarOrang)
            {
                orang.InfoOrang();
                orang.Aktivitas();
                Console.WriteLine("<><><><><><><><><><><><><><><<>");
            }
        }
    }
}