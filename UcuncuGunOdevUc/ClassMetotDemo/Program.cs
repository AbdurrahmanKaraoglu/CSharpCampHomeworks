using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            MusteriManager musteriManager = new MusteriManager();
            
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = 123215;
            musteri1.Ad = "Abdurrahman";
            musteri1.Soyad = "Karaoğlu";
            musteri1.TcKimlikNo = "11111111111";
            musteri1.Telefon = "05555555555";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = 5324542;
            musteri2.Ad = "Ahmet";
            musteri2.Soyad = "Özberk";
            musteri2.TcKimlikNo = "22222222222";
            musteri2.Telefon = "05555552222";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.MusteriNo = 5342346;
            musteri3.Ad = "Ömer";
            musteri3.Soyad = "Doğan";
            musteri3.TcKimlikNo = "33333333333";
            musteri3.Telefon = "05555553333";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            musteriManager.MusteriListele(musteriler);

            Console.WriteLine("------------------------------");

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.MusteriNo = 4423562;
            musteri4.Ad = "Ali";
            musteri4.Soyad = "Veli";
            musteri4.TcKimlikNo = "44444444444";
            musteri4.Telefon = "05555554444";
            musteriManager.MusteriEkle(musteri4);

            Console.WriteLine("------------------------------");

            musteriManager.MusteriSil(musteri2);

            
        }
    }
}
