using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfizmornek
{
    public class ProfilKup:TemelUrun
    {
        public override string ToString()
        {
            return ID + " " + UrunAd+" "+Yukseklik;
        }
        public override decimal GetTabanAlani()
        {
            return Yukseklik * Yukseklik * Yukseklik;
        }
        
    }
}
