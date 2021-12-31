using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nothesaplama
{
    public class Ogrenci:IOgrenci
    {
        private int _ogrenciNo;
        public int ogrenciNo { get; set; }
        //{
            //get
            //{
            //    Random rnd = new Random();
            //    _ogrenciNo = rnd.Next(1000, 2000);
            //    return _ogrenciNo;
            //    ;
            //}
            //set {; }
       // }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public double Sınav1 { get; set; }
        public double Sınav2 { get; set; }
        public double ortalama { get; set; }

       public double Ortalama()
        {
            return (Sınav1 + Sınav2) / 2;
        }
    }
}
