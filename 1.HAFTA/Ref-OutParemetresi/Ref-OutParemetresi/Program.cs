using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_OutParemetresi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string metin1, metin2;
            //    int uzunluk;
            //Console.WriteLine("Metin1 giriniz");
            //metin1 = Convert.ToString(Console.ReadLine());
            //Console.WriteLine("Metin2 giriniz");
            //metin2 = Convert.ToString(Console.ReadLine());

            //uzunlukhesapla(metin1, metin2, out uzunluk);
            //Console.WriteLine($"uzunluğu büyük olan: {uzunluk}");
            //*int a = 50, b = 40, max;
            //*buyukgetir(a,b,out max);
            //*Console.WriteLine($"sayıların en büyüğü : {max}");

            int x = 5,c;
            Console.WriteLine("Sayi :"+x);
            Console.WriteLine("Sayının karesi:" +kare(x,out c));
            Console.WriteLine("Sayının küpü:"+c);
            Console.ReadLine();
        }
        private static int kare(int a,out int y)
        {
            int k;
            k = a * a;
            y = a * a * a;
            return k;
        }
       /* private static void buyukgetir(int a, int b, out int max)
        {
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
        }*/
        //private static void uzunlukhesapla(string metin1, string metin2, out int uzunluk )
        //{
        //    if (metin1.Length> metin2.Length)
        //    {
        //        uzunluk= metin1.Length;
        //    }
        //    else
        //    {
        //        uzunluk = metin2.Length;
        //    }

        //}

    }
}
