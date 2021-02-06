using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("{0} Id'li müşteri eklendi.", musteri.Id);
        }
        public void MusteriListele(Musteri[] musteriler)
        {
            for (int i = 0; i < musteriler.Length; i++)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Müşteri Id: " + musteriler[i].Id);
                Console.WriteLine("Müşteri Adı: " + musteriler[i].Ad);
                Console.WriteLine("Müşteri Soyadı: " + musteriler[i].Soyad);
                Console.WriteLine("Müşteri Şehir: " + musteriler[i].Sehir);
                Console.WriteLine("------------------------------");
            }
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("{0} Id'li müşteri silindi.", musteri.Id);
        }
    }
}
