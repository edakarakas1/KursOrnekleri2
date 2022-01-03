using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadsMethods
{
    internal class Program
    {
        static string sonuc;
        static double sonucd;
        static int[] sayilar = { 5, 10, 12, 20 };
        static void Main(string[] args)
        {

            Console.WriteLine(ToplamAl("eda", "karakas"));
            Console.WriteLine(ToplamAl(5,3.5));
            Console.WriteLine(ToplamAl(sayilar));
            Console.WriteLine(ToplamAl(true,8,9,12,78,20));
            Console.ReadLine();

        }
        private static string ToplamAl(string ad,string soyad)
        {
       return sonuc=ad +" "+ soyad;
        }
        private static double ToplamAl(double s1 ,double s2)
        {
            return sonucd = s1 +s2;
        }
        private  static Double ToplamAl(int[] dizi)
        {
            for(int i=0;i<dizi.Length;i++)
            {
                sonucd += dizi[i];   
            }
            return sonucd;
        }
        private static double ToplamAl(bool b,params int[] dizi)//params ın yazımı bu şekilde olmalı params dan başka birşey alamaz alacaksada da başta olmalı params en sağda olmalı 
        {
            foreach (var item in dizi)
            {
                sonuc += item;
            }
            return sonucd;

        }
    }
}
