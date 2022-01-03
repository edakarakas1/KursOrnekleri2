using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasitMethotTanımlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a=6, b = 8;
            ////Console.WriteLine(ToplamAl(a, b));
            //Console.WriteLine(CarpımAl(a, b));
            //saatkac();
            //merhaba();
            Console.WriteLine("kenar1");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kenar2");
            int s2 = Convert.ToInt32(Console.ReadLine());
            alanhesapla(s1,s2);
            Console.ReadLine();

        }

        private static int alanhesapla(int a1, int a2)
        {
            switch (a1)
            { case int kontrol when a1==a2:
                    Console.WriteLine("Girdiğiniz değer karedir");
                    break;
                case int kontrol when a1 < a2 || a1 > a2:
                    Console.WriteLine("Dikdörtgenin alanı {s1*s2}");
                    break;
                default:
                    break;
            }
            return a1 * a2;
        }

        //private static void merhaba()
        //{
        //    Console.WriteLine("merhaba");
        //}
        //private static void saatkac()
        //{
        //    Console.WriteLine(DateTime.Now);
        //}



        //static int ToplamAl(int a, int b)
        //{
        //    int sonuc = a + b;
        //    return sonuc;
        //}
        //private static int CarpımAl(int a,int b)
        //{
        //    int sonuc= a*b;
        //    return sonuc;
        //}
    }
}
