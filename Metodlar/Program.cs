using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdı = "Elma";
            double fiyatı = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] {"Elma","Karpuz" };

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 10;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Product[] products = new Product[] {urun1,urun2 };

            foreach (var product in products)
            {
                Console.WriteLine(
                    "ÜrünAdı: " + product.Adi +
                    "ÜrünFiyatı: " + product.Fiyati +
                    "ÜrünAciklama :" + product.Aciklama);

                Console.WriteLine("--------------------");

                Console.WriteLine("-----------Metotlar---------------");
                // instance - CLASS ÖRNEĞİ OLUŞTURMA
                SepetManager sepetManager = new SepetManager();
                sepetManager.Ekle(urun1);
                sepetManager.Ekle(urun2);
                // ENCAPSULATİON - İÇERDE BİR DEĞİŞİKLİK YAPMAK İÇİN CLASSIN İÇİNDE YAPMAMIZ YETERLİ OLUR !
                sepetManager.Ekle2("Elma", "Amasya Elması", 12, 10);
                sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 8);
                sepetManager.Ekle2("Portakal", "Dörtyol Portakalı", 12, 26 );

            }

        }
    }
}
