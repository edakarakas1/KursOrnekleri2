using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtımornek
{
    public class temelinsan
    {
        public int id { get; set; }
        public long TC { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Cinsiyet { get; set; }

        public Adres[] Adres;
        public temelinsan()
        {
            Adres=new Adres[4];
        }

    }
}
