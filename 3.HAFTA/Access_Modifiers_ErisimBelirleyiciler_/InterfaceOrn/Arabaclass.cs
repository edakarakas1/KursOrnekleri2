using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrn
{
    public class Arabaclass : Inumara, Iaraba
    {
        int _modelYili;
        int _yildiz;
        public int yildiz { 
            get {return _yildiz; } 
            set {_yildiz = value>5?5:value;}
                
                 }
        public string marka { get ; set; }
        public string sanzıman { get; set; }
        public string model { get ; set ; }
        public int modelYili { 
            get 
            {
                return _modelYili; 
            } 
            
            set {
                if (value<2005)
                {
                    _modelYili = value;
                }
                else
                {
                    _modelYili = value;
                }

                ; } }

       

        public void ozellikOku() {
            Console.WriteLine("Araç Özelliklerimiz+Markası: "+marka+ "Şanzıman Türü:"+sanzıman+ "ModelYılı:"+_modelYili+"Puanı"+_yildiz);
        }
        
    }
}
