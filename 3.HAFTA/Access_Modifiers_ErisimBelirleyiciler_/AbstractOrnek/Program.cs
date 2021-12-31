using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {//Abstract Class:Kendimize işimize yarayacak bir model çıkarıyoruz.
            //Absract sınıflar örneklenmez.Şablon olarak kullanılır.Kural kütüphanesidir.
            //ondan kalıtım alan sınıflar yapıcı metodunu çalıştırabilir.Ama program.cs de örneklenmez
           // temelsinif t = new temelsinif();

            //abstract olarak tanımlı metodları kullanmak zorunda bırakır eğer başında abstract ifadesi yoksa implement etmeyi zorunlu kılmaz
            //abstract sınıflar sealed kullanılmaz.
            musteri m1 = new musteri();
            m1.test();
            m1.testAbstract();
            superMusteri sp = new superMusteri();
            sp.testAbstract();


           
        }
    }
}
