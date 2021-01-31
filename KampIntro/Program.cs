using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int sayı = 5;
            double faiz = 1.45;
            bool sistemeGirmişmi = true;
            double DolarBugün = 7.50;
            double DolarDün = 7.45;

            if (DolarBugün>DolarDün)
            {
                Console.WriteLine("Artış oku");
            }
            else if (DolarBugün<DolarDün)
            {
                Console.WriteLine("Azalış oku");

            }
            else
            {
                Console.WriteLine("Eşit");
            }

            /////////////////////////////////////////////
            if (sistemeGirmişmi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");

            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine("Ternary Operatör");
            string sonuc = DolarBugün < DolarDün ? "Azalış Oku" : "Artş Oku"; 
            Console.WriteLine(sonuc);

            int sayi = 0;
            int toplam = 0;
            while (sayi<=100)
            {
                if (sayi % 2 == 1)
                {
                    toplam += sayi;

                }
                sayi++;
            }
            Console.WriteLine("Teksayılarının Toplamı:"+toplam);

            
            
        }
    }
}
