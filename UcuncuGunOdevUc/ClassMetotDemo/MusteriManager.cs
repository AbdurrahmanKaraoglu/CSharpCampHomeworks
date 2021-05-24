using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Id : " + musteri.Id + " Müşteri No : " + musteri.MusteriNo + " Ad : " + musteri.Ad
                    + " Soyad : " + musteri.Soyad + " Tc Kimlik No : " + musteri.TcKimlikNo + " Telefon : " + musteri.Telefon);

            Console.WriteLine("Bilgilerine Sahip Müşteri Eklendi.");
        }

        public void MusteriListele(Musteri[] musteri)
        {
            foreach (var oankiMusteri in musteri)
            {
                Console.WriteLine("Id : " + oankiMusteri.Id + " Müşteri No : " + oankiMusteri.MusteriNo + " Ad : " + oankiMusteri.Ad
                    + " Soyad : " + oankiMusteri.Soyad + " Tc Kimlik No : " + oankiMusteri.TcKimlikNo + " Telefon : " + oankiMusteri.Telefon);
            }
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriNo + " Nolu Müşteri Silindi!");
        }
    }
}
