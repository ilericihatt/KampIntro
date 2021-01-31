using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Kurs kurs1 = new Kurs();
            kurs1.KursAdı = "C#";
            kurs1.Egitmeni = "Cihat İleri";
            kurs1.IzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = "Python";
            kurs2.Egitmeni = "Murat Seven";
            kurs2.IzlenmeOranı = 67;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdı = "Java";
            kurs3.Egitmeni = "Batuhan Zorlu";
            kurs3.IzlenmeOranı = 70;


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar) 
            {
                Console.WriteLine(kurs.KursAdı + " : " + kurs.Egitmeni);
            }


            //Console.WriteLine(kurs1.KursAdı + " : " + kurs1.Egitmeni);








        }
    }

    class Kurs
    {
        public string KursAdı { get; set; }
        public string Egitmeni { get; set; }
        public int IzlenmeOranı { get; set; }
    }
}
