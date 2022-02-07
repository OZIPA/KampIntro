using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "AmasyaElmasi";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakir Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };
            
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi + ": " + urun.Fiyati);
            }


            Console.WriteLine("--------Metotlar--------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yesil", 12,10);
            sepetManager.Ekle2("Elma", "Yesil", 12,9);
            sepetManager.Ekle2("Karpuz", "db", 12,3);


        }
    }
}


//Dont repeat yourself- DRY- Clean Code