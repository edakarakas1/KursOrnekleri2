using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumkullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            c.id = 1;
            c.isim = "eda";
            c.emailAdress = "edakarakas@";
            c.musteriNo = "5";
            SanalDatabase db = new SanalDatabase();
            CustomerReturnValue musterikayitsonuc = db.musteriyenikayitekle(c);
            int enumsayi = (int)CustomerReturnValue.kayitbasarisiz;
            Console.WriteLine(enumsayi);
            Console.WriteLine(musterikayitsonuc);
            Console.ReadLine();

        }
    }
}
