using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
     class BasvuruManager
    {  //metot enjekte etme 
        public void BasVuruYap(IKrediManager krediManager ,ILoggerService loggerService)
        {
            //Basvuran bilgilerini değerlendirme
            //
            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> Krediler)
        {
            foreach (var Kredi in Krediler)
            {
                Kredi.Hesapla();
            } 
        }
    }
}
