using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sanalmethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            musteri musteri = new musteri();
            musteri.isim = "eda";
            musteri.soyisim = "karakas";
            string mesaj=musteri.ToString();//Namespace.Class ismini yazar
            Console.WriteLine(mesaj);   
            Console.ReadLine();

        }
    }
}
