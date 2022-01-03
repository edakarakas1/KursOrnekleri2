using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadORN
{
    internal class Program
    {
        static double sonucd;//devamı var

        static int sonuc;
        static int[] sayilar = { 3, 5, 7, 9, 11 };
        static void Main(string[] args)
        {

            Console.WriteLine("1. sayi giriniz...");
            int s1 =Convert.ToInt32( Console.ReadLine());
            
            Console.WriteLine("2. sayi giriniz...");
            int s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(ToplamAl(s1,s2));
           

            Console.ReadLine();
        }
        private static Double ToplamAl(double a,double b)
        {
            return a + b;
        }
        private static int ToplamAl(int s1,int s2)
        {
            return sonuc = s1 + s2; 
        }


    }
}
