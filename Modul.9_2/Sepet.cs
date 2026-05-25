using System;
using System.Collections.Generic;
using System.Text;

namespace Modul._9_2
{
    internal class Sepet
    {
        public delegate void SepetHandler();
        public event SepetHandler UrunEklendi;

        public List<Urun> Urunler = new List<Urun>();

        public void Ekle(Urun urun)
        {
            Urunler.Add(urun);
            if (UrunEklendi != null)
            {
                UrunEklendi();
            }
        }

        public double ToplamTutar()
        {
            double toplam = 0;
            foreach (var u in Urunler) toplam += u.Fiyat;
            return toplam;
        }

    }
}
