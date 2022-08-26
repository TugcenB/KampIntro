using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri = new GercekMusteri();
            musteri.Id = 1;
            musteri.MusteriNo = "12345";
            musteri.Adi = "Tuğçe";
            musteri.Soyadi = "Bilgin";
            musteri.TcNo = "12345678910";


            //Kodlama.io
            TuzelMusteri musteri1= new TuzelMusteri();
            musteri1.Id = 2;
            musteri1.MusteriNo = "54321";
            musteri1.SirketAdi = "Kodlama.io";
            musteri1.VergiNo = "1234567890";

            Customer musteri2 = new GercekMusteri();
            Customer musteri3 = new TuzelMusteri();
            //Hem gerçek hem tüzel   //new ref. no oluşturuyor.

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri);
            customerManager.Add(musteri1);

        }
    }
}