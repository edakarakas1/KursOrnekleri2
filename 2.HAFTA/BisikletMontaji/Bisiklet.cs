using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisikletMontaji
{
    public class Bisiklet
    {
        public FrenTipi Fren { get; set; }

        public KadroTipi Kadro { get; set; }
        int yil = DateTime.Today.Year;
        private int _Modelyil;
        public int Modelyil {get
            {
                return _Modelyil;
                ; }

            set {
                if (value<1990 || value>yil)
                {
                    throw new Exception("Yıl ifadesi 1990 ile " + yil + "arasında olabilir");
                }
                else
                {
                    _Modelyil = value;
                }
                
                ; }
        }
        public int yasi { get {return yil-_Modelyil; } private set {; } }
        public override string ToString()
        {
            return $"Bisiklet Freni: {this.Fren}- Kadrosu : {this.Kadro} - Yaşı: {this.yasi}";
        }







        
    }
}
