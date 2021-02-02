using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);

            int[] sayılar1 = new int[] {10,20,30 };
            int[] sayılar2 = new int[] {100,400,600 };
            sayılar1 = sayılar2;
            sayılar2[0] = 99;
            Console.WriteLine(sayılar1[0]);



          
        }
    }
}
