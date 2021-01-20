using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 245;
            musteri1.MusteriAdi = ("Ahmet Furkan");
            musteri1.MUsteriSoyadi = ("Çomak");
            musteri1.MusteriTC = "14618339856";
            musteri1.MusteriTelefon = "******4554";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 437;
            musteri2.MusteriAdi = ("Emirhan");
            musteri2.MUsteriSoyadi = ("Söğüt");
            musteri2.MusteriTC = "35467687635";
            musteri2.MusteriTelefon = "******3487";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 245;
            musteri3.MusteriAdi = ("Ezgi Tuğçe");
            musteri3.MUsteriSoyadi = ("Bolat");
            musteri3.MusteriTC = "24534354387";
            musteri3.MusteriTelefon = "******2424";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 245;
            musteri4.MusteriAdi = ("Berkehan");
            musteri4.MUsteriSoyadi = ("Çevik");
            musteri4.MusteriTC = "36525416676";
            musteri4.MusteriTelefon = "******0666";

            Musteri musteri5 = new Musteri();
            musteri5.Id = 245;
            musteri5.MusteriAdi = ("Burak");
            musteri5.MUsteriSoyadi = ("Özçelik");
            musteri5.MusteriTC = "67854624354";
            musteri5.MusteriTelefon = "******4550";

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3, musteri4 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Bankamıza Hoşgeldiniz :" + musteri.MusteriAdi + " " + musteri.MUsteriSoyadi + "    Müşteri Id " +"-"+ musteri.Id);
                Console.WriteLine("-------------------------");
            }


            Console.WriteLine("----GÜNCELLEMELER----");


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri5);
            musteriManager.MusteriSil(musteri3);
        }
    }
}
