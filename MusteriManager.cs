using ClassMetotDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager : IMusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " adlı müşteri eklendi");
        }

        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + " - " + musteri.Ad + " " + musteri.Soyad);
            }
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " adlı müşteri silindi");
        }
    }
}
