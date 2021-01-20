using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        // Naming convention (Metod Başharfi Büyük)
        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Sepete Eklendi : " + urun.Adi);
        }


        public void Ekle2(string urunAdi, string aciklama, double fiyat, int adet)
        {
            Console.WriteLine("Sepete Eklendi : " + urunAdi);
        }



        

    }
}
