using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListGeneric
{
    internal class Program
    {
        private static object arraylist;

        static void Main(string[] args)
        {
            ArrayList a=new ArrayList();
            a.Add(1);
            a.Add("bir");

            //--T tipi demek .net framework içerisinde olan veya bizim oluşturduğumuz herhangi bir tip demek

            List<int> liste = new List<int>();
                liste.Add(1);
                liste.Add(2);
            //liste.Add("bir");

            for (int i = 0; i < liste.Count; i++)
            {
                Console.WriteLine(liste[i]);
            }
            List<string> slist = new List<string>();
            slist.Add("deneme");
            slist.Add("eda");
            slist.Add("2");
            List<musteri> m = new List<musteri>();
            m.Add(new musteri()
            {
                id = 1,
                isim = "eda",
                soyisim = "karakas"
            });
            //musteri m2 =new musteri();
            //m2.id=1;
            foreach (musteri item in m)
            {
                Console.WriteLine(item.isim);
            }
            //--------------
            List<int> sayilarim = new List<int>();
            sayilarim.Add(1);
            int[] eklenecek = new int[5];
            eklenecek[0]= 23;
            eklenecek[1]= 3;
            eklenecek[2]= 5;
            eklenecek[3]= 8;
            eklenecek[4] =13;
            //1.yol uzun
           /* for (int i = 0; i <eklenecek.Length; i++)
            {
                sayilarim.Add(eklenecek[i]);
            }*/
            //2.yol
            sayilarim.AddRange(eklenecek);//toplu şekilde sayı ekler.

            int capacity = sayilarim.Capacity;
            int count=sayilarim.Count;


            //Soru: sayılarım koleksiyonunun içerisinde bulunan detayı ekrana yazdır.
            sayilarim.ForEach(x => Console.WriteLine(x));
            //=> ilgili koleksiyon içerisinde arama yap 
            //=> ling konusu

            int bulunan = sayilarim[3];
            Console.WriteLine("3. indexdeki eleman {0}",bulunan);
            
            sayilarim.Insert(3, 100);//ilgili indexteki değeri silmez bir aşağı kaydırıp arasına ekleme yapar.
            bool kontrol1 = sayilarim.Any();//içerisinde şart yoksa ilgili yerde data var mı yok mu kontrol eder.

            bool kontrol2 = sayilarim.Any(i => i > 500);//verilen yer içerisinde 500den büyük değer var mı diye kontrol eder.

            sayilarim.Sort();//a-z ye 1-N kadar sıralama yapar
            sayilarim.Reverse();//z-a ya n-1 kadar 

            int enyuksek = sayilarim.Max();
            int endusuk = sayilarim.Min();
            int toplam = sayilarim.Sum();
            Console.WriteLine("en yüksek :" +enyuksek+  "endusuk:" +endusuk+  "toplam:" +toplam);

            bool silmeislemi = sayilarim.Remove(5);//verilen değere göre silme yapar.
            sayilarim.RemoveAt(2);//verilen indexe göre silme yapar.
                                  //Soru:sayılarım içerisinde yer alan 3 ten büyük elemanları sil ve kaç adet olduğunu bana değişkenle ata

            int s=sayilarim.RemoveAll(x => x > 3);
            sayilarim.Clear();
            Console.WriteLine(s);
            
            Console.ReadLine();
        }

        
    }
}
