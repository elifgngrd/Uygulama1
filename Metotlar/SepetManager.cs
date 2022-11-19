using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class SepetManager
    {
      public void Ekle(Urun urun) //metot çalıştırma (Buyuk yazılan Urun tipi kuçuk yazılan urun isimlendirme)
        {
            Console.WriteLine("Sepete Eklendi: " + urun.Adi);
        }




    }
}
