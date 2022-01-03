using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x=20,y=10;
            degistir(ref x,ref y);
            Console.WriteLine($"x in yeni değeri={x}");
            Console.WriteLine($"y nin değeri eşittir ={y}");
            Console.ReadLine();
        }
        static void degistir(ref int a ,ref int b)
        {
            int gecici = a;
            a = b;//10
            b= gecici;//20
        }
    }
}
