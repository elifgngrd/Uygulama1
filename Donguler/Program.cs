namespace Donguler
{
     class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici";
            string kurs2 = "programlamaya giris";
            string kurs3 = "java kursları";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);   
            Console.WriteLine(kurs3);

            string[] kurslar = new string[] {"yazılım geliştirci","programlamaya giris",
            "java kursları","c#" };

            for (int i = 0; i < kurslar.Length; i++)//i=i+2 ikişer arttır.(i+=2)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar) //dizi temelli yapıları tek tek dönmeye yarıyor
            {                                // item kısmı döngünun elamanlarının adı 
                Console.WriteLine(kurs);

            }

            Console.WriteLine("sayfa sonu");
        }

    }
}