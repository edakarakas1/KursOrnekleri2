using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfizmornek
{
    public class ProfilSilindir:TemelUrun
    {
        public decimal Yaricap { get; set; }
        public override decimal GetTabanAlani()
        {
            return Yaricap * Yaricap * 22 / 7;
        }
        public override string ToString()
        {
            return ID + " " + UrunAd;
        }

    }
}
