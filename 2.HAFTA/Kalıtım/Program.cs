using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Kalıtım -Miras Alma-Inhertance
            ---Kalıtımda oluşturulan nesneler birbirinden türetilebilir ve türeyen nesne türetilen 
            nesnenin tüm özellikleri kullanabilir.
             */
            Ogrenci o=new Ogrenci();
            o.ToString();//aslında object türünden örnek almış oluyorum .Gelen farklı metodlar bir yerden miras alarak geldi
            //Üzerine bakınca object nesnesinden miras alıp geldiğini gördüm 
           
            Egitmen  e= new Egitmen();
            e.Ad = "eda";
            Calisan c= new Calisan();
            c.gorev = "zzzzz";
        }
    }
}
