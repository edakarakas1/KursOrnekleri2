using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka_Uygulama
{
    public class Musteri
    {
        public int id { get  ;   set ;  }
        public string Ad { get; set; }
        public string soyad;
        private string _kredikart;
        public string kredikart
        {
            get { return getkredikart(); }
            set { _kredikart = value; }
        }
        public string getkredikart()
        {
            string gecici="";
            int sayi = _kredikart.Substring(0,_kredikart.Length-2).Length;

            for (int i = 0; i < sayi; i++)
            {

                gecici = gecici + "*";
            }
            return gecici+ _kredikart.Substring(_kredikart.Length- 2) + gecici;

        }
        
    }
}

