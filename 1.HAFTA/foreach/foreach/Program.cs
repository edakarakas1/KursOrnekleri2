using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-------------------Foreach döngüsü
            //string[] isim = { "Eda", "Selin", "Salih","Ayşe","Lale" };
            //foreach (string item in isim)
            //{
            //    Console.WriteLine(item);    
            //}
            //Console.ReadLine();

            //1)Ekrana 1-10 a kadar sayıların değerini yazma
            //for döngüsü ile
            //for (int i = 1; i <=10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //int sayac = 1;
            ////-----------while döngüsü ile
            //while (sayac<=10)
            //{
            //    Console.WriteLine(sayac);
            //    sayac++;    
            //}


            //Console.ReadLine();



            //2)Alt alta 3-2-1-0 yazan program
            //int sayac = 3;
            //while (sayac!=-1)
            //{
            //    Console.WriteLine(sayac);
            //    sayac--;    
            //}

            //3)
            //Kullanıcıya şifre soran bilinmez ise 5 hak tanıyan her seferinde kalan hakkıda belirten uygulama sifre:1234
            //int sayac = 5;
            //int sifre = 1234;


            //while (sayac>0)
            //{
            //    Console.WriteLine("Şifrenizi giriniz");
            //    int s = Convert.ToInt32(Console.ReadLine());
            //   sayac--;
            //    if (s==sifre)
            //    {
            //        Console.WriteLine("Giriş başarılı...");
            //    }
            //    else if(sifre!=s)
            //    {
            //        Console.WriteLine($"kalan hakkınız :{sayac}");    
            //    }
            //    if (sayac==0)
            //    {
            //        Console.WriteLine("Yanlış şifre girdiniz...");
            //    }
            //}


            //Console.ReadLine();
            //4)sistemin çalışma zamanından oluşturduğu 1 ile 10 arasındaki bir değeri kullanıcının tahmin etmesini isteyecek bir uygulama yazalım...


            //Random sayiuret=new Random();   
            //int uretilensayi=sayiuret.Next(1,10);
            //int tahmin = 0;
            //while (true)
            //{
            //    Console.WriteLine("Tuttuğum sayıyı tahmin et");
            //   int s=Convert.ToInt32(Console.ReadLine());  
            //   tahmin++;

            //    if (uretilensayi==s)
            //    {
            //        Console.WriteLine($"{tahmin} . tahminde doğru bildiniz");
            //        break;
            //    }

            //    else
            //    {
            //        Console.WriteLine("Yanlış tahmin yeniden deneyiniz...");
            //    }
            //}

            //---------------Do While döngüsü

            //5)1 ile 100 arasındaki rakamları tek ve çift olmak üzere sıralayalım.Tek ve Çift sayıları toplayıp ekrana yazdırsın
            //int sayac = 1;
            //int toplam = 0;
            //int cift = 0, tek = 0;
            //do
            //{
            //    Console.WriteLine(sayac % 2 == 0 ? sayac + " :Çift" : sayac + " :Tek");
            //    //ternary ile toplama işlemi
            //    cift = sayac % 2 == 0 ? cift + sayac : cift + 0;
            //    tek = sayac % 2 != 0 ? tek + sayac : tek + 0;
            //    sayac++;


            //}
            //while (sayac <= 100);
            //Console.WriteLine(cift);
            //Console.WriteLine(tek);
            //------------
            // hata var bakkk
            //int sayac = 1;
            //int cift = 0, tek = 0;
            //do
            //{
            //    if (sayac % 2 == 0)
            //    {
            //        cift += sayac;
            //    }
            //    else
            //    {
            //        tek += sayac;
            //    }
            //    Console.WriteLine(sayac % 2 == 0 ? sayac + " :Çift" : sayac + " :Tek");
            //}

            //---------
            //string[] isim = { "ali", "demet", "seda" };
            //int[] s = new int[5];

            //int[] a =new int[4] {1,2,3,4};

            //int[] b = new int[4];
            //b[0] = 5;
            //b[1] = 3;
            //b[2] = 3;
            //b[3] = 8;


            //foreach (int sayi in b)
            //{
            //    Console.WriteLine(b[2]);
            //}

           /* forla yazımı b içerisindeki elemanları yazdırma
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }*/


            /*--------Uygulama:int veri tipinde dizi oluşturalım.Kullanıcımız dizinin kaç elemanlı olacağı bilgisini versin ve 
            içerisine elemanların atamasını yapsın.Daha sonra dizi içerisindeki elemanların toplamlarını ve ortalamalarını ekrana
            yazdıran uygulama.
            Console.WriteLine("Kaç elemanlı dizi oluşturmak istersiniz...");
            int elemanS = Convert.ToInt32(Console.ReadLine());
            int[] sayi = new int[elemanS];
            int toplam = 0, ort = 0;
            for (int i = 0; i < sayi.Length; i++)
            {
                Console.WriteLine($"{i} indeksli sayi giriniz...");
                int eleman = Convert.ToInt32(Console.ReadLine());
                sayi[i] = eleman;
            }
            foreach (int item in sayi)
            {
                Console.WriteLine(item);
                toplam += item;
            }
            Console.WriteLine($"Sayıların toplamı{toplam}");

            ort = toplam / sayi.Length;
            Console.WriteLine($"sayıların ortalaması{ort}");

            Console.ReadLine(); */

            /*----------UYGULAMA: 20 Elemanlı bir int dizisi oluşturalım değerimizi random sınıfının next fonksiyonu ile 
            1ila 10 arasında dolduralım daha sonra dizi içerisindeki elemanlarımızı ekrana yazdıralım ve ilgili
            dizi içerisinde kaça tane 4değeri olduğunu bulalım.

            int[] dizi = new int[20];
            Random rnd = new Random();
            int sayac=0;
            for (int i = 0; i <dizi.Length; i++)
                {
                dizi[i] = rnd.Next(1, 10);
                }
            foreach (int item in dizi)
            {
                Console.WriteLine(item);
                if (item==4)
                {
                    sayac++;
                }
            }

            Console.WriteLine($"{sayac} adet 4 bulundu");


                Console.ReadLine();*/


            Console.ReadLine();
        }
    }
}
