using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> age = new MyDictionary<string, int>();
            age.Add("Gülce Yılmaz", 20);
            age.Add("Fatma Güven", 56);
            age.Add("Ali Sayer", 27);
            age.Add("Berkay Yılmaz", 14);

            
        }
    }
}
