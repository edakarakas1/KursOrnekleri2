using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reqursive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            Console.WriteLine($"{i} sayısının faktoriyeli : " +$"{faktoriyel(i)}");
            Console.ReadLine();

        }
        static int faktoriyel(int n )
        {
            if (n == 0)
                return 1;
            return n *faktoriyel( n - 1);
            
        }
    }
}
