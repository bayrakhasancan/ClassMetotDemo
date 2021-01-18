using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Hasan Can";
            musteri1.Soyad = "Bayrak";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Ali";
            musteri2.Soyad = "Demir";


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriListele(new Musteri[] { musteri1, musteri2 });

            Console.ReadKey();

        }
    }
}
