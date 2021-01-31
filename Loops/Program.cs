using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            // array - dizi(TEK BİR LİSTEDE VERİLERİ TOPLAMAK TEK TEK UĞRAŞMAMAK İÇİN)

            string[] kurslar = new string[] { "Yazılım Geliştirici Kampı", "Programlamaya başlangıç için temel kurs", "Java" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }


            Console.WriteLine("Sayfa sonu");

            foreach (var kurs in kurslar) 
            {
                Console.WriteLine(kurs);
            }

            
            
            
            
            


        }
    }
}
