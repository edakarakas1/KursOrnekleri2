using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havayollari
{
    internal class Program
    {
        static int sayac;
        static int koltuksecim;
        static string[] economy = { "", "", "", "", "", "", "", "", "", "", "", "" };
        static string[] business = { "", "", "", "", "", "", "",  };
       
        static string isim, tus;
        static void Main(string[] args)
        {

            anaMenu();
            isimal();
            koltukkontrol();
            rezervasyon();
            Main(null);
            Console.ReadLine();


        }
        private static void anaMenu()
        {
            Console.WriteLine("1.Business Class bölümü için 1 tuşuna basınız");
            Console.WriteLine("2.Economy Class bölümü için 2 tuşuna basınız");
            int tus = Convert.ToInt32(Console.ReadLine());//tus=console.readLine();
            switch (tus)
            {
                case 1:
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("Lütfen geçerli bir seçim yapınız...");
                    anaMenu();

                    break;
            }

            //if (sayac == isim.Length)
            //{
            //    Console.WriteLine("Bilet Alamazsınız...");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    anaMenu();
            //    isimal();
            //    koltukkontrol();
            //    rezervasyon();
            //    Main(null);
            //    Console.ReadLine();


            //}
        }
        private static void isimal()
        {//
            Console.WriteLine("Lütfen Adınızı Giriniz...");
            isim = Console.ReadLine();
            for (int i = 0; i < isim.Length; i++)
            {
                if (char.IsDigit(isim[i]))
                {
                    Console.WriteLine("Lütfen sayısal karakter girmeyiniz...");
                    isimal();
                }
            }       
        }
        private static void koltukkontrol()
        {
            int sayac = 0;
            if (tus=="1")
            {

            for (int i = 0; i < business.Length; i++)//
            {
                if (economy[i] == " ")
                {

                    Console.WriteLine($"{i} . koltuk boş");
                }
                else
                {
                    Console.WriteLine($"{i} . {business[i]} tarafından dolu");
                }
            }
            if (sayac == business.Length)
            {
                Console.WriteLine("Uçak Dolu");
            }
            else if (sayac != business.Length)
            {

                Console.WriteLine("Yerimiz mevcuttur");
                }
            }


            if (tus == "2")
            {

                for (int i = 0; i < economy.Length; i++)
                {
                    if (economy[i] == " ")
                    {

                        Console.WriteLine($"{i} . koltuk boş");
                    }
                    else
                    {
                        Console.WriteLine($"{i} . {economy[i]} tarafından dolu");
                    }
                }
                if (sayac == economy.Length)
                {
                    Console.WriteLine("Uçak Dolu");
                }
                else if (sayac != economy.Length)
                {

                    Console.WriteLine("Yerimiz mevcuttur");
                }
            }
        }
        private static void rezervasyon()
        {
            if (tus=="1")
            {
                Console.WriteLine("İstediğiniz koltuğu seçiniz");
                koltuksecim = Convert.ToInt32(Console.ReadLine());

                if (business[koltuksecim] == "")
                {
                    business[koltuksecim] = isim;
                  
                }
                else
                {
                    Console.WriteLine($"{economy[koltuksecim]} numaralı koltuk {isim[koltuksecim]} tarafından rezerve edilmiiştir.Boş koltuklardan seçiniz...");
                    rezervasyon();
                }
                Console.WriteLine($"[koltuksecim] numaralı koltuk{economy[koltuksecim]} tarafından rezerve edilmiiştir.");
                koltukkontrol();
            }
           else if (tus == "2")
            {
                Console.WriteLine("İstediğiniz koltuğu seçiniz");
                koltuksecim = Convert.ToInt32(Console.ReadLine());

                if (economy[koltuksecim] == "")
                {
                    economy[koltuksecim] = isim;

                }
                else
                {
                    Console.WriteLine($"{koltuksecim} numaralı koltuk {economy[koltuksecim]} tarafından rezerve edilmiiştir.Boş koltuklardan seçiniz...");
                    rezervasyon();
                }
                Console.WriteLine($"{koltuksecim} numaralı koltuk{economy[koltuksecim]} tarafından rezerve edilmiiştir.");
                koltukkontrol();
            }
           
            Console.ReadLine();
   
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            //    }foreach (string tus in isim)
    //            {
    //                if (tus == "1")
    //                {
    //                    sayac++;
    //                    isimal();
    //}
    //                else if (tus == "2")
    //                {

    //                }
                }

    }
}
