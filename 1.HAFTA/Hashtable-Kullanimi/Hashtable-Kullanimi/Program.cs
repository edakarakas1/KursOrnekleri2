using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable_Kullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1)Hashtable h1 =new Hashtable();
             h1.Add("car","araba");
             h1.Add("house","ev");
             h1.Add("cars", "arabalar");

             bool kontrol = h1.Contains("house");
             bool kontrol2 = h1.Contains("door");
             bool kontrol3 = h1.ContainsValue("ev");
             bool kontrol4 = h1.ContainsKey("cars");
             h1["house"] = "villa";
             h1.Remove("cars");
             h1.Clear();

             Console.WriteLine($"{kontrol}   {kontrol2}    {kontrol3}   {kontrol4}");
             Console.ReadLine();*/

            //2)Hashtable içerisine ENG -TR olarak data eklemeniz
            /*
             yeni kayıt eklemek istiyor musunuz E/H
            E:Yeni kayıt ekleme işlemi devam etsin
            H:Tüm listeyi yazdırın
            Var olan bir key değeri ekliyor ise kullanıcıya bu değer daha önceden ... şeklinde sistemimizde bulunmaktadır.

             */
            Hashtable sozluk = new Hashtable();
           
           
            do
            {
                Console.WriteLine("Eklemek istediğiniz sözlük değerini yazınız");
                Console.WriteLine("Eng:");
                string eng=Console.ReadLine();
                bool kontrol = sozluk.Contains(eng);
                if (kontrol)
                {
                    Console.WriteLine($"Eklemek istediğiniz {eng} sözlük içerisinde bulunmaktadır.kelimenin karşılığı {sozluk[eng]} ");
                }
                else
                {
                    Console.WriteLine($"{eng} değerinin türkçe karşılığını giriniz");
                    string tr = Console.ReadLine();
                    sozluk.Add(eng, tr);
                    Console.WriteLine( "Değer ekleme işlemi başarılı");
                }
                Console.WriteLine("Yeni değer eklemek istiyor musunuz ? E/H");
            } while (Console.ReadLine().ToUpper()!="H");

            foreach (var item in sozluk.Keys)
            {
                Console.WriteLine($"ENG: {item} Tr:{sozluk[item]}");
            }
               


            Console.ReadLine();
        }
    }
}
