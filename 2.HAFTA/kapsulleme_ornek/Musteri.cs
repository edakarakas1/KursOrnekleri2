using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsulleme_ornek
{
    public class Musteri
    {
        public Musteri()
        {
            IdAtama();
        }
        private int _id;
        public int id { get { return _id; } private set {; } }
        private int IdAtama()
        {
            Random rnd = new Random();
            _id = rnd.Next(1000, 9000);
            return _id;
        }
        public string isim { get; set; }
        private string _soyisim;
        public string soyisim
        {
            get { return _soyisim;}
            set {_soyisim=value;
                _email = string.Format("{0}.{1}@gmail.com",isim,_soyisim);
            }
        }
        private string _email;
        public string email { get { return _email; } set { _email=value;} }

        public string _TcKimlik;
        public string TcKimlik
        { get {
                int sayi =( _TcKimlik.Substring(3)).Length;
                string tc = "";
                for (int i = 0; i < sayi; i++)
                {
                    tc = tc + "*";
                }

                 return _TcKimlik.Substring(0,3)+tc;
               
                 ;
            }
            set {
                if (value.Length == 11)
                {
                    bool kontrol = false;
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool karakterkontrol = char.IsNumber(value[i]);
                        if (karakterkontrol)
                        { 
                            //sayısal değer}
                        }
                        else
                        {
                            kontrol = true;
                            break;
                        }
                    }
                    if (kontrol)
                    {
                        Console.WriteLine("Tc sayılardan oluşmalı");

                    }
                    else
                    {
                        _TcKimlik = value;
                    }
                }
                else
                {
                    _TcKimlik="";
                }
                
                ; } }

    }

}

