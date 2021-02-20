using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "engin";
            musteri1.Soyadi = "demiroğ";
            musteri1.TcNo = "545121335";


            //kodlama.io 

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "6564";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "4545456466";

            //Gerçek Müşteri- Tüzel Müşteri
            //SOLID



            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
        }
    }
}
