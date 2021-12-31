using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kupdikdörtgenInterface
{
    public class Kupkutu : Iurun
    {
       // private int _id;
       // private string _ad;
        //private int _yukseklik;
        public int id { get; set; }
        public string ad { get; set; }
        public int yukseklik { get; set; }


        internal int hacim()
        {
            double hacim = Math.Pow(Convert.ToDouble(yukseklik),3);
            return Convert.ToInt32(hacim);
        }
    }
}

