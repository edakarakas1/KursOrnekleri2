using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfizmornek
{
    public class ProfilDortgen:TemelUrun
    {
        public decimal uzunkenar { get; set; }
        public decimal kisakenar { get; set; }
        public decimal TabanAlan { get; set; }
        public override string ToString()
        {
            return ID + "" + UrunAd;
        }
        public override decimal GetTabanAlani()
        {
            return uzunkenar * kisakenar;
        }
    }
}

