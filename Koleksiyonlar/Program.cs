using System.Collections.Generic;

namespace Koleksiyonlar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] isimler = new string[] {"Elif","Ezgi","Berfin","Zülal" };

            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
          
            List<string> isimler2 = new List<string> {"ELİF","EZGİ","BERFİN","ZÜLAL"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("İLKER");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }
    }
}