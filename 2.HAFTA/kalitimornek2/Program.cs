using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalitimornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {//debug la içlerine bakıldı
           bilgisayar B1=new bilgisayar();
            B1.marka = "Lenova";
            B1.model = "z50";
            B1.islemci = "i5";
            B1.alisfiyati = 5000;
            B1.satisfiyati = 5500;
            B1.kampanyafiyat = 100;
            B1.Barkod = "1234567";
            sanaldatabase.yeniUrunEkle(B1);


            bilgisayar B2 = new bilgisayar();
            B2.marka = "Lenova";
            B2.model = "z50";
            B2.islemci = "i5";
            B2.alisfiyati = 5000;
            B2.satisfiyati = 5500;
            B2.kampanyafiyat = 100;
            B2.Barkod = "1234566";
            sanaldatabase.yeniUrunEkle(B2);


            bilgisayar B3 = new bilgisayar();
            B3.marka = "Lenova";
            B3.model = "z50";
            B3.islemci = "i5";
            B3.alisfiyati = 5000;
            B3.satisfiyati = 5500;
            B3.kampanyafiyat = 100;
            B3.Barkod = "1234555";
            sanaldatabase.yeniUrunEkle(B3);

            Console.ReadLine();
        }
    }
}
