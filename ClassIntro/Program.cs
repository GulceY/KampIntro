using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdı = "C#";
            kurs1.KursunEgitmeni = "Kerem ";
            kurs1.KatılımOranı = 80;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = " Python";
            kurs2.KursunEgitmeni = "Berkay";
            kurs2.KatılımOranı = 40;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdı,"  ",kurs.KatılımOranı);
            }


        }
    }

    class Kurs
    {
        public string KursAdı { get; set; }
        public string KursunEgitmeni { get; set; }
        public int ızlemeOranıy { get; set; }
        public int KatılımOranı { get; internal set; }
    }
}        
