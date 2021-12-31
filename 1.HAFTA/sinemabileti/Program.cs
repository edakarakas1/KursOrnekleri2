using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinemabileti
{
    internal class Program
    {
        static string isimgelen = " ";
        static int koltuksecim = 0 ;
        static int[] koltukNumrasi = { 0, 1, 2, 3, 4, 5, 6, 7 };
        static string[] isimler = { "", "", "", "", "", "Ahmet", "", "" };
        static int sayac = 0;
        static void Main(string[] args)
        {
            if (sayac ==0)
            {
                foreach (string item in isimler)
                {
                    if (item != "")
                    {
                        sayac++;
                    }
                }
            }
            if (sayac == isimler.Length)
            {
                Console.WriteLine("Bilet alamazsınız");
                Console.Read();
            }
            else
            {
                isimal();
            }
            isimal();
            koltukKontrol();
            rezervasyon();
        }

        private static void isimal()
        {
            Console.WriteLine("Lütfen adınızı giriniz: ");
            isimgelen = Console.ReadLine();
            for(int i = 0; i < isimgelen.Length; i++)
            {
                if (char.IsDigit(isimgelen[i]))
                {
                    isimal();
                }
            }
        }

        private static void koltukKontrol()
        {
            for (int i = 0; i < isimler.Length; i++)
            {
                if (isimler[i] == "")
                    Console.WriteLine($"{i} . koltuk boş");
                else
                    Console.WriteLine($"{i} . koltuk {isimler[i]} tarafından dolu");
            }
            if(sayac == koltukNumrasi.Length)
            {
                Console.WriteLine("SALON DOLU");
            }
            else if (sayac != koltukNumrasi.Length)
            {
                Console.WriteLine("SALON BOŞ");
            }
        }

        private static void rezervasyon()
        {
            try
            {
                Console.WriteLine("Seçmek istediğiniz koltuk numarasını giriniz: ");
                koltuksecim=Convert.ToInt32(Console.ReadLine());
                sayac++;
                if (isimler[koltuksecim] == "")
                {
                    isimler[koltuksecim] = isimgelen;
                    sayac++;
                }
                else
                {
                    Console.WriteLine("Seçtiğiniz koltuk dolu. lütfen yeni koltuk seçin");
                    rezervasyon();
                }
                Console.WriteLine($"{koltukNumrasi[koltuksecim]} numaralı koltuk  {isimler[koltuksecim]} kişi tarafından rezerve edilmiştir.");
                koltukKontrol();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Hatalı Koltuk seçimi yaptınız!");
                rezervasyon();
            }
        }
    }
}
