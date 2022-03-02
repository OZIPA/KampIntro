using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "Ilker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Ilker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

            Dictionary<int, string> listem = new Dictionary<int, string>();

            listem.Add(1, "Ocak");

            Console.WriteLine(listem[1]);


            MyDictionary<int, string> haftaninGunleri = new MyDictionary<int, string>();

            haftaninGunleri.Add(1, "Pazartesi");

            Console.WriteLine(haftaninGunleri.Count);
            
            haftaninGunleri.Add(2, "Sali");

            Console.WriteLine(haftaninGunleri.Count);

            
        }
    }
}
