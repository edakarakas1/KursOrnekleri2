using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsulleme_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Field değer ataması yapılmasın ama değer okunsun.
             * Fiel değer ataması ve okuma işlemleri yapılsın ama bu iki işlemde bizim belirlediğimiz bir süreçten
             * geçsin veri daha sonra gösterilsin.
             * field değer ataması yapılsın ama değer okunmasın
             * field değer ataması yapılsın ama değerin ilk3 hanesi okunsun
             * 
             
             */
            Musteri m = new Musteri();
            // m.id = 12333;
            m.isim = "eda";
            m.soyisim = "karakas";  
            Console.WriteLine(m.id);
            Console.WriteLine(m.email);
            m.TcKimlik = "54544541478";
            Console.WriteLine("Tc girin");
            m.TcKimlik = m.TcKimlik;
            Console.WriteLine(m.TcKimlik);
            Console.ReadLine();


        }
    }
}
