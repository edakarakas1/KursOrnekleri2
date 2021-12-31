using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sanalmethodtostring
{
    public class Ogrenci
    {
        public int id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string AdSoyad { get; set; }
        public Ogrenci()
        {
            AdSoyad = Ad + " " + Soyad;
        }

        public override string ToString()
        {
            return id+" "+Ad + " " + Soyad;
        }

    }
}
