using ClassMetotDemo;
using System;

namespace Odev3
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Gülce";
            musteri1.Soyad = "Yılmaz";
            musteri1.ID = "12345678";
            musteri1.MusteriNo = "56";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Zeynep";
            musteri2.Soyad = "Güneş";
            musteri2.ID = "78979878979";
            musteri2.MusteriNo = "78";

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Ege";
            musteri3.Soyad = "Kurtoğlu";
            musteri3.ID = " 122323290";
            musteri3.MusteriNo = "34";

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.ID);
                Console.WriteLine(musteri.MusteriNo);
                Console.WriteLine("............");
            }

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            musteriManager.Ekle2(musteri1);



      
        }
    }
}
