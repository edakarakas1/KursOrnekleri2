using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
   public class Arac
    {
        /*    * marka
              * model
              * model_yıl
              * km
              * yakıt_tipi
              * vites_tipi
              * alış_fiyat
              * satış_fiyat
              * max_indirim
              * fiyat*/

        public string marka;
        public string model;
        public int modelyil;
        public decimal km;
        public int yakittipi;
        public int vitestipi;
        public decimal Alisfiyati;
        public decimal Satisfiyati;
        public int MaxindirimTutari;
        public decimal fiyat;
       
        public Arac()
        {
           
        }
       
        public Arac(string _marka,string _model)
        {
            marka = _marka;
            model = _model;
        }
        public Arac(string _marka, string _model,int _modelyili)
        {
            marka = _marka;
            model = _model;
            modelyil = _modelyili;
        }
        public Arac(string _marka, string _model, int _modelyili,decimal _km)
        {
            marka = _marka;
            model = _model;
            modelyil = _modelyili;
            km = _km;
        }


        public void BilgileriGoruntule()
        {
            Console.WriteLine("Marka {0} -Model {1} -Model Yıl{2}" ,marka,model,modelyil);
        }
        
        public void FiyatAta (decimal _fiyat)
        {
            decimal fiyathesap = Satisfiyati - MaxindirimTutari;
            if (_fiyat<fiyathesap)
            {
                Console.WriteLine("Geçersiz fiyat girişi ");
            }
            else
            {
                this.fiyat = _fiyat;
                Console.WriteLine("Fiyat güncellendi");
            }
        }

    }
}
