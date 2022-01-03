using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace get_type_typeof
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veri Girin...");
            string s =Console.ReadLine();   
            if (s is string)
            {
                Console.WriteLine($"verinin tipi {s} tipi string");
            }
            Console.ReadLine();
        }
    }
}
