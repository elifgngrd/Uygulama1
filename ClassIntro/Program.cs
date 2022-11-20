namespace ClassIntro
{
    public class Program
    {
        static void Main(string[] args)
        {
            string adi = "Elif";
            int yas = 27;

            //  kurs Classnın değişkenleri ve değer ataması 
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "Elif";
            kurs1.IzlemeOrani = 65;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "Ertan";
            kurs2.IzlemeOrani = 26;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.Egitmen = "Ece";
            kurs3.IzlemeOrani = 78;

            // Console.WriteLine(kurs1.KursAdi +" : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen + " - % " + kurs.IzlemeOrani);

            }

            Urun urun1 = new Urun(); //urun classının değişkeni oluştutuldu
            urun1.ayakkabi = "nikeayakkabı ";
            urun1.mont = "puma mont";
            urun1.canta = "adidas canta ";

            Urun urun2 = new Urun();
            urun2.ayakkabi = "cocuk ayakkabi";
            urun2.mont = " cocuk mont";
            urun2.canta = "cocuk canta";

            Urun urun3 = new Urun();
            urun3.ayakkabi = "erkek ayakkabi";
            urun3.mont = "erkek mont";
            urun3.canta = "erkek canta";

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.ayakkabi + " : " + urun.mont + " : " + urun.canta + "  ");
            }

        }

    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlemeOrani { get; set; }

    }
    class Urun
    {
        public string ayakkabi { get; set; }
        public string mont { get; set; }
        public string canta { get; set; }
    }

}