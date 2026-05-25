using System;
using System.Collections.Generic;
using System.Text;

namespace Modul._8_1
{
    class Insan
    {
        public double Boy, Kilo;
        public string Ad;

        public Insan(string ad)
        {
            this.Ad = ad;
            this.Boy = 182;
            this.Kilo = 100;
        }

        public virtual void Buyu()
        {
            Boy += 0.5;
            Kilo += 0.5;
        }
    }
    class Ogrenci : Insan
    {
        public Ogrenci(string ad) : base(ad)
        {
        }

        new public void Buyu()
        {
            this.Boy += 1.5;
            this.Kilo += 1.5;
        }
    }

    class Ogretmen : Insan { public Ogretmen(string ad) : base(ad) { } }
    class Mudur : Insan { public Mudur(string ad) : base(ad) { } }
}
