using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvruruManager
    {
        // metod enjeksiyonu
        public void BasvuruYap(IKrediBaseManager krediBaseManager,ILoggerService loggerService)
        {
            // başvuran bilgilerini değerlendirme
            krediBaseManager.Hesapla();
            loggerService.log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediBaseManager> krediler) 
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
        
    }  






}
