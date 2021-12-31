using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfizmornek
{
    public class TemelUrun
    {
        public int ID { get; set; }
       // public string UrunAd { get; set; }
        public string _UrunAd;
        public string UrunAd
        {
            get
            {
                int s = (_UrunAd.Substring(1).Length);
                string a = " ";
                for (int i = 0; i < s; i++)
                {
                    a = a + "*";

                }
                return _UrunAd.Substring(0, 1) + a;
            }

            set
            {

                _UrunAd = value;

                
            }
        }
        public decimal Yukseklik { get; set; }
        
        public decimal Fire()
        {
            return GetHacim() * 20 / 100; 
        }

        public  decimal GetHacim()
        {
            return GetTabanAlani() * Yukseklik;
              
        }

        public virtual decimal GetTabanAlani()
        {
            return Yukseklik * Yukseklik;
        }
       
        }
    }

