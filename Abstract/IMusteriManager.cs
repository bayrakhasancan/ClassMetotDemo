using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo.Abstract
{
    interface IMusteriManager
    {
        void MusteriEkle(Musteri musteri);
        void MusteriListele(Musteri[] musteriler);
        void MusteriSil(Musteri musteri);
    }
}
