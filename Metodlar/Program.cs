using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {

            // Metodlar - Tekrar Tekrar Kullanılabilirliği sağlıyor - do not repeat yourself(kendini tekrar etme) 
            // DRY  +  Clean Code  + Best Practice (doğru uygulama teknikleri)

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2};

            // type safe -- tip güvenliği 
            foreach (Urun urungetir in urunler)
            {
                Console.WriteLine("Ürün Adı      : " + urungetir.Adi);
                Console.WriteLine("Ürün Fiyatı   : " + urungetir.Fiyati);
                Console.WriteLine("Ürün AÇıklama : " + urungetir.Aciklama);
                Console.WriteLine("=============================================");

            }

            Console.WriteLine("-----------------Metodlar-----------------------------");

            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);

            //encapsulation 
            
            //classa eklediğin metod değişiklerde kolaylık sağlar..

            //önerilmeyen sistem -değişiklik istendiğinde sorun teşkil eder
            sepetmanager.Ekle2("Armut", "Deveci", 15,5);
            sepetmanager.Ekle2("Muz", "Anamur", 18,7);
            sepetmanager.Ekle2("Karpuz", "Diyarbakır", 27,12);





        }
    }
}
