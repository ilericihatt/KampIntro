using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediBaseManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediBaseManager tasitKrediManager = new IhtiyacKrediManager();
            IKrediBaseManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileloggerService = new FıleLoggerService();

            BasvruruManager basvruruManager = new BasvruruManager();
            basvruruManager.BasvuruYap(konutKrediManager, databaseLoggerService);

            List<IKrediBaseManager> krediler = new List<IKrediBaseManager>() { ihtiyacKrediManager,konutKrediManager };
            //basvruruManager.KrediOnBilgilendirmesiYap(krediler);






           

            

        }
    }
}
