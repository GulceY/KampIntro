using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Gülce";
            musteri1.Soyadi = "Yılmaz;";
            musteri1.Tc = "124115514151";
            musteri1.Id = 1;


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54545454";
            musteri2.SirketAdi = "Apple";
            musteri2.VergiNo = "123556";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(musteri1);




        }
                
    }
}
