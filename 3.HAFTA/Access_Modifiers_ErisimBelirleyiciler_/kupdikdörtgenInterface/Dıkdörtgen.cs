using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kupdikdörtgenInterface
{
    public class Dıkdörtgen : Iurun
    {
        //private int _id;
        //private string _ad;
        //private int _yukseklik;
        //private int _kısakenar;
        //private int _uzunkenar;
        public int id { get; set; }
        public string ad { get; set; }
        public int yukseklik { get; set; }
    public int kısakenar { get; set; }
    public int uzunkenar { get; set; }

        public int hacim()
        {
            return yukseklik * kısakenar * uzunkenar;
        }
    }
}
