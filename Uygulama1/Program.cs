namespace Uygulama1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori"; //kategori etiketi burda değer tututcudur
            int ogrenciSayisi = 320000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi= true;
            double dolardun = 7.45;
            double dolarbugun = 8.45;

            if (dolardun>dolarbugun)
            {
                Console.WriteLine("azalış butonu göster");
            }
            else if(dolardun<dolarbugun) 
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }

            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);

        }
    }
}