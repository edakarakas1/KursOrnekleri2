using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme
{
    public class Ogrenci
    {/*Kapsülleme:İçerisine saklamış olduğumuz private bir field ın önüne koyduğumuz biir property 
      * sayesinde get ve set kullanarak deger ataması yapabilir ve değer okuyabiliriz.*/
        private string _Ad;
        public string Ad 
        {
            get{return _Ad; }


            set{ _Ad = value.Substring(0, 1).ToUpper() + value.Substring(1) ; }
        }
        private string _Soyad;
        public string Soyad 
        {
            get {return _Soyad; }
            set { _Soyad = value.Replace(value,"*")+value.Substring(value.Length-2,2); }
        }
        private long _TC;
        public long TC {
        
            get{return _TC; }
            set{_TC=Math.Abs(value); } 
        }


    }
}
