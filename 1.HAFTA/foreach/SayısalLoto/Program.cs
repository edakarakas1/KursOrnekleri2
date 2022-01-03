using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayısalLoto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[6];
            Random rnd = new Random();
            string sayi = ""; 
            for (int i = 0; i <=6; i++)
            {
                int sayiuret=rnd.Next(0,50);
                if (!sayi.Contains(sayiuret.ToString()))
                {
                    sayi=$"{sayiuret}  {sayi} ";
                    sayilar[i]=sayiuret;

                }
               
            }
            Console.Write(sayi);
            Array.Sort(sayilar);
            foreach (int item in sayi)
            {
                Console.WriteLine(item);
            }
           
            Console.ReadLine();
            
        }
    }
}
