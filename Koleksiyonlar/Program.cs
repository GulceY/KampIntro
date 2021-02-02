using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Gülce" };
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string>() {"Engin","Murat","Gülce" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            isimler2.Add("Aslı");

            
        }
    }
}
