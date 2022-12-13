﻿namespace OOP2
{
    public class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Adi = "Elif";
            musteri1.Soyadi = "Güngördü";
            musteri1.Id = 1;
            musteri1.TcNo = "2563947554";
            musteri1.MusteriNo = "12345";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54632";
            musteri2.SirketAdi = "kodlama";
            musteri2.VergiNo = "1234567";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);

            
        }
    }
}