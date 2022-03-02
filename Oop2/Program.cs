using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demier";
            musteri1.TcNo = "1231423525";


            //Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "3423422";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "342423524";




            //Gercek musteri-Tuzel musteri
            //SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

        }
    }
}
