using System;

namespace Medotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrununAdı = "Elma";
            urun1.Fıyatı = 15;
            urun1.Acıklaması = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.UrununAdı = "Karpuz";
            urun2.Fıyatı = 80;
            urun2.Acıklaması = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.UrununAdı);
                Console.WriteLine(urun.Fıyatı);
                Console.WriteLine(urun.Acıklaması);
                Console.WriteLine("..................");
            

            }

            Console.WriteLine("............Metodlar...........");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
           




        }
    }
}
