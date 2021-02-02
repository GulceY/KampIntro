using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<K,V>
    {
        K[] array1;
        V[] array2;

        public MyDictionary()
        {
            array1 = new K[0];
            array2 = new V[0];

        }

        public bool Count { get; internal set; }

        public void Add(K item1, V item2)
        {
            K[] Copy1 = array1;
            V[] Copy2 = array2;

            array1 = new K[array1.Length + 1];
            array2 = new V[array2.Length + 1];


            for (int i = 0; i < Copy1.Length; i++)
            {
                array1[i] = Copy1[i];
                array2[i] = Copy2[i];

            }

            array1[array1.Length - 1] = item1;

            array2[array2.Length - 1] = item2;

            Console.WriteLine(item1 + " "+ item2);
            
            
        }



    }
}
