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
            musteri1.Ad = "Berke";
            musteri1.Soyad = "Karaman";
            musteri1.Sehir = "Istanbul";
            musteriManager.MusteriEkle(musteri1);

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Ahmet";
            musteri2.Soyad = "Demir";
            musteri2.Sehir = "Ankara";
            musteriManager.MusteriEkle(musteri2);

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Emir";
            musteri3.Soyad = "Çevik";
            musteri3.Sehir = "Izmir";
            musteriManager.MusteriEkle(musteri3);

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            musteriManager.MusteriListele(musteriler);

            musteriManager.MusteriSil(musteri2);

            musteriler = new Musteri[] { musteri1, musteri3 };
            musteriManager.MusteriListele(musteriler);

        }
    }
}
