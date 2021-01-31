using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 3200;
            double dolarDun = 1.44;
            double dolarBugun = 1.45;
            bool sistemeGirisYapmisMi = false;


            if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else 
            {
                Console.WriteLine("Değişmedi Butonu");
            }





            Console.WriteLine(kategoriEtiketi);




        }
    }
}
