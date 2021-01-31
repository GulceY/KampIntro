using System;

namespace Ödev2
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Model = "İPhone 12 Pro";
            urun1.Fiyat = 14.999;
            urun1.Buton = "Satın Al";

            Urun urun2 = new Urun();
            urun2.Model = "İPhone 12";
            urun2.Fiyat = 9.999;
            urun2.Buton = "Satın Al";

            Urun urun3 = new Urun();
            urun3.Model = "İphone 11";
            urun3.Fiyat = 7.999;
            urun3.Buton = "Satın Al";


            Urun[] urunlar = new Urun[] {urun1,urun2,urun3};

            // for döngüsü içim

            for (int i = 0; i < urunlar.Length; i++)
            {
                Console.WriteLine(urunlar[i]);
            }


        }
    }

    class Urun
    {
        public string Model { get; set; }

        public double Fiyat { get; set; }
        public string Buton { get; set; }
        public string Icerik{ get; set; }
    }
}

