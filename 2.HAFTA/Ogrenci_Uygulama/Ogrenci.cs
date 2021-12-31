using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenci_Uygulama
{
    public class Ogrenci
    {
        /*
        Öğrenci
        ogrenci no=Bölümadının ilk harfi(büyük)+Sınıf+rastgale üretilen sayı
        ad
        soyad
        bölüm
        sınıf
        alınan bilgiler data gride eklenicek ve seçtiğinde diğer textboxta gösterilecek 
 */
        int sayi;
        public Ogrenci()
        {
            Random rnd = new Random();
            sayi= rnd.Next(1000, 9000);
         
        }
        public string Adı { get; set; }
        public string Soyadı { get; set; }
        public string Sinif { get; set; }
        public string Bölümü { get; set; }
        public string _ogrencino;
        public string ogrencino {
            get {string d= Bölümü.Substring(0,1).ToUpper()+Sinif+sayi;
                _ogrencino = d;
                return _ogrencino;
                ; }
            set
            {
                _ogrencino= value;
            }
        }

       
       
       

    }
}
