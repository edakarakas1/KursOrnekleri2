using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    public class Musteri
    {
        /*
         tc
        isim
        soyisim
        cinsiyet 
        */

        public string TcKimlikNumarası;
        public string isim;
        public string soyisim;
        public int cinsiyet;//777100101:erkek 777100102:kadın
        public Musteri() 
        {
            //hiç dokunmazsanız varsayılandefault değeriyle çalışır.
            TcKimlikNumarası = "12213231111";//diğer halini ezdim git bunu kullan dedim
 
        }
        public Musteri(string _tckimlikno) //overload gibi kullanıcam
        {
            TcKimlikNumarası = _tckimlikno;
        }
        public Musteri(string _tckimlikno,string _isim) 
        {
            TcKimlikNumarası = _tckimlikno;
            isim= _isim;
        }
        public Musteri(string _tckimlikno, string _isim,string _soyisim)
        {
            TcKimlikNumarası = _tckimlikno;
            isim = _isim;
            soyisim= _soyisim;  
        }

        //Bir  methodtan başka bir methoda gidebiliriz bu şekilde tanımlanır
        public bool MusteriKontrol()
        {
            bool kontrol = MusteriKontroldatabase(TcKimlikNumarası);
            return kontrol;
        }
        private bool MusteriKontroldatabase(string tc)
        {
            //database bu tc kimlik  numaralı kişi varmı kontrol işlemi yapıldığını varsayıyorum
            return true;
        }

    }
}
