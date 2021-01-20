using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Bankamıza Hoşgeldiniz :" + " " + musteri.MusteriAdi+" "+musteri.MUsteriSoyadi + "    Müşteri Id " + "-" + musteri.Id);
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Değerli Müşterimiz :" + " " + musteri.MusteriAdi + " " + musteri.MUsteriSoyadi + " Bankamızdan Ayrıldı");
        }
    }
}
