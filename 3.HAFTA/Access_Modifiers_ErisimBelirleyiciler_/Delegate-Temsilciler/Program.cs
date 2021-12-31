using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Temsilciler
{
     class Program
    { /*---Delegate-Temsilciler
       * Aynı metot imzasına sahip olan methodları tutan ve liste içerisinde barındıran yapılardır.Metod
        tutucu olarak ta bilinir.
       * Metod imzası :Hangi parametre alıyor ne donuyor buna bakar
       * 
       
       */
        delegate void Matematikselislemler(int sayi1, int sayi2);
        static void Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam işleminin sonucu : {0}", sonuc);
        }
        static void Cıkartma(int sayi1, int sayi2)
        {
            int sonuc = sayi1 - sayi2;
            Console.WriteLine("Çıkarma işleminin sonucu : {0}", sonuc);

        }
        static void Carp(int sayi1, int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            Console.WriteLine("Çarpma işleminin sonucu : {0}", sonuc);

        }
        static void Main(string[] args)
        {
            /*Topla(10, 20);
            Cıkar(10, 20);
            Carp(10, 20);*/
            Matematikselislemler m1 = new Matematikselislemler(Topla);
            m1 += Cıkartma;
            m1 += Carp;

            m1.Invoke(30,2);//Metodları bu değerlerle çalıştırır.

            Delegate[] isaretedilenmetodlar=m1.GetInvocationList();
            foreach (var item in isaretedilenmetodlar)//delegate de olan metodların isimlerini görmek için 
            {
                Console.WriteLine(item.Method.Name);
            }

            m1 -= Carp;//topla cıkartma görünür carpı cıkardı
            foreach (var item in m1.GetInvocationList())
            {
                Console.WriteLine(item.Method.Name);
            }

            m1 -= Cıkartma;//topla  görünür cıkartma cıkardı
            foreach (var item in m1.GetInvocationList())
            {
                Console.WriteLine(item.Method.Name);
            }


            Console.ReadLine();
        }
    }
}
