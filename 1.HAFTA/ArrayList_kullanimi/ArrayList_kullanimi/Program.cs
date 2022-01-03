using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_kullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int capacity = 0;
            int count = 0;  
           // string[] isim = new string[10];
            ArrayList A1 = new ArrayList();
            A1.Add("sınıf");
            A1.Add("Eda");
            A1.Add(5);
            A1.Add("deger");
            capacity = A1.Capacity;
            count = A1.Count;
            Console.WriteLine($"dizinin kapasitesi :{capacity} countu : {count}");

            ArrayList A2 = new ArrayList();
            A2.Add(5);
            A2.Add(12);
            A2.Add(21);
            A1.AddRange(A2);

            object o1 = A1[3];//A1 3. elemanını getir
            A1.Remove(2);//2 numaralı indexdekini kaldır
            A1.Reverse();//terse dönderir 
            A1.Sort();//kendi içinde sıralama yapar string ifadede string ,int ifadede int sıralama yapar, ikisi bir olursa hata verir sıralama yapamaz
            if (A1.Contains("Eda"))
            {
                int s = A1.IndexOf("Eda");
                A1.Remove(s);
            }
            bool kontrol = A1.Contains(5);
            Console.WriteLine(kontrol);

            A1.Clear();//diziyi siler
            A1.TrimToSize(); //dizinin kapasitesini boyutlandırmamıza yarar*/
            #region  örn:10 elemanlı  bir array listin içerisindeki değerleri z-a olacak şekilde sırala
            ArrayList A1 = new ArrayList();

            A1.Add("Eda");
            A1.Add("Arda");
            A1.Add("Veli");
            A1.Add("Can");
            A1.Add("Kerim");
            A1.Add("Doğa");
            A1.Add("Ferdi");
            A1.Add("Nesibe");
            A1.Add("Büşra");
            A1.Add("Zeynep");
            A1.Sort();           
            A1.Reverse();

            foreach (var item in A1)
            {
                Console.WriteLine(item);
            }
            //for (int i = 0; i < A1.Count; i++)
            //{
            //    Console.WriteLine(A1[i]);
            //}
            #endregion


            Console.ReadLine();
        }
    }
}
