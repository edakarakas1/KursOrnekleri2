using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaBileti
{
    internal class Program
    {
        static int sayac;
        static string isimgelen = "";
        static int koltuksecim = 0;
        static int[] koltukNumarasi = {0,1,2,3,4,5,6,7 };
        static string[] isimler = {"","","","","","Eda","","" };
        static void Main(string[] args)
        {
            if (sayac==0)
            {
                foreach (string item in isimler)
                {
                    if (item!="")
                    {
                        sayac++;
                    }
                }
            }
            if (sayac==isimler.Length)
            {
                Console.WriteLine("Bilet Alamazsınız...");
                Console.ReadLine();
            }
            else//
            { //anamenu();
            isimal();
            koltukkontrol();
            rezervasyon();
            Main(null);
            Console.ReadLine();
            }
        }

       

        private static void isimal()
        {
            Console.WriteLine("Lütfen Adınızı Giriniz...");
            isimgelen = Console.ReadLine();
            for (int i = 0; i < isimgelen.Length; i++)
            {
                if (char.IsDigit(isimgelen[i]))
                {                                         
                    isimal();
                }

            }
        }
        
        private static void koltukkontrol()
        {
            
            for (int i = 0; i <isimler.Length; i++)
            {
                if (isimler[i]==" ")
                {
                   
                    Console.WriteLine($"{i} . koltuk boş");
                }
                else 
                    {
                    Console.WriteLine($"{i} . {isimler[i]} tarafından dolu");
                }
            }
            if (sayac==koltukNumarasi.Length)
            {
                Console.WriteLine("Salon Dolu");
            }
            else if (sayac!=koltukNumarasi.Length)
            {
               
                Console.WriteLine("Salon Boş");

            }
        }
        private static void rezervasyon()
        {
            try
            {
                Console.WriteLine("İstediğiniz koltuğu seçiniz");
                koltuksecim=Convert.ToInt32(Console.ReadLine());
                if (isimler[koltuksecim]=="")
                {
                    isimler[koltuksecim] = isimgelen;
                    sayac++;
                }
                else 
                { 
                    Console.WriteLine("Seçtiğiniz koltuk dolu");
                    rezervasyon();
                }
                Console.WriteLine($"{koltukNumarasi[koltuksecim]} numaralı koltuk {isimler[koltuksecim]} tarafından rezerve edilmiiştir.");
                koltukkontrol();
            }
            catch (Exception)
            {
                Console.WriteLine("Olmayan koltuk seçimi");
                rezervasyon();

            }
        }
    }
}
