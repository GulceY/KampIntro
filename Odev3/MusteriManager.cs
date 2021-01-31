using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müsteri Eklendi" + "    " + musteri.Ad + " " + musteri.Soyad);


        }

        public void Ekle2(Musteri musteri)
        {
            Console.WriteLine("Müsteri Silindi" + "  " + musteri.Ad + "  " + musteri.Soyad);


        }
    }
}
