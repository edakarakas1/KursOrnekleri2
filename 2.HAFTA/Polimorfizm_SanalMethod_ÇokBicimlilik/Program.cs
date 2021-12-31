using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm_SanalMethod_ÇokBicimlilik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Class içerisinde bulunan bir metodun istenilirse türeyen sınıf içerisinde  yeniden şekillenebir.
             
             */
            BaseClass b = new BaseClass();
            b.ekranaYaz("merhaba");

            Urun u = new Urun();
            u.ekranaYaz("deneme");

            televizyon t=new televizyon();
            t.ekranaYaz("hangisi?");

            Console.ReadLine();
        }
    }
}
