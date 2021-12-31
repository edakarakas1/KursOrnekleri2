using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalitimornek2
{
    internal class urun:baseclass
    {
        public string marka { get; set; }
        public string model { get; set; }
        private decimal _alisfiyati;
        public decimal alisfiyati 
        {
            get {return _alisfiyati; }  
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Alış fiyatı 0 dan küçük olamaz");
                }
                else
                {
                    _alisfiyati = value;
                }


                    ; }  
        }//0 dan küçük olmamalı
        private decimal _satisfiyati;
        public decimal satisfiyati
        {
            get {return _satisfiyati; }
             set {
                if (value<_alisfiyati)
                {
                    Console.WriteLine("Satış fiyatı alış fiyatından küçük olamaz");
                }
                else
                {
                    _satisfiyati = value;
                }
                ; } 
        }//alış fiyatından küçük olamaz
        private decimal _kampanyafiyat;
        public decimal kampanyafiyat
        {
            get {return _kampanyafiyat; }
             set {
                if (value<=0)
                {
                    Console.WriteLine("Kampanya fiyatı 0 dan küçük olamaz");
                }
                else
                {
                    _kampanyafiyat = value;
                }
                ; }
        }//0dan küçük olamaz




    }
}
