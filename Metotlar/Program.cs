namespace Metotlar
{
    public class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 60;
            urun2.Aciklama = "diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 }; //Urun adı içerisinde dizi oluşturuldu

            foreach (var urun in urunler) //var yerine Urun yazılabilir Urun veri tipitir.
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("-----------Metotlar--------------");

            SepetManager sepetManager = new SepetManager(); //class çağırma class örneği oluşturma
            sepetManager.Ekle(urun1);                            //metot çağırma
            sepetManager.Ekle(urun2);





        }
    }
}