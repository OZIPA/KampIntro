﻿using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;

            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 10, 20, 20 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            sayilar1[1] = 222;

            Console.WriteLine(sayilar2[1]);


        }
    }
}
