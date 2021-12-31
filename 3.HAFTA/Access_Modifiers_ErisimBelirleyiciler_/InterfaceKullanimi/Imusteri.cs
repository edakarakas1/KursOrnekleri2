using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceKullanimi
{
    public interface Imusteri
    {
        // public Imusteri(){} interface de yapıcı method kullanılmaz .Tamamen şablondur
        //field
        //değişken tanımlanmaz sadece property oluşturabilirim
        //interface örneklenmez.
        //clasıma birden fazla interfaceten miras alabilirim
        int Id { get; set; }
        //Erişim belirleyicisi kullanamam 
        string isim { get; set; }
        string soyisim { get; set; }

        int yenikayit(string isim, string soyisim);//metodun imzası yer alır
        int kayitduzenle(int id, string isim, string soyisim);
       
      


    }
}
