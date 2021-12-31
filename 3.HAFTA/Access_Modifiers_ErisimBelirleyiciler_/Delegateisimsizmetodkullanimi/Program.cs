using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegateisimsizmetodkullanimi
{
    class Program
    {
        delegate void EkranaYaz(string a, string s);
        static void Main(string[] args)
        {
            //Var olan bir metodu kullanarak içine ekleme
            EkranaYaz test1 = new EkranaYaz(TestMetod);

            test1("eda", "karakas");
            //İsimsiz metod kullanımı 
            EkranaYaz test2 = new EkranaYaz(delegate (string a, string s)
            {
                Console.WriteLine(a+ " " +s);
            });
            test2("semra", "mert");
            Console.ReadLine();

        }
        static void TestMetod (string a,string s)
        {
            Console.WriteLine(a+ " " +s);
        }
    }
}
