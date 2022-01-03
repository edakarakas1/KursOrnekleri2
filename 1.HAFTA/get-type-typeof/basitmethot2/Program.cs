using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basitmethot2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("acı1");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("acı2");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("acı3");
            int s3 = Convert.ToInt32(Console.ReadLine());
            ucgenKontrol(s1, s2,s3);
            Console.ReadLine();
        }
        private static void ucgenKontrol(int s1, int s2, int s3)
        {
            switch (s1)
            {
                case int kontrol when s1 == s2 && s1 == s3 && s2 == s3:
                    Console.WriteLine("Eşkenar Üçgen ");
                    break;

                case int kontrol when s1 == s2 || s2==s3 || s1==s3:
                    Console.WriteLine("İkizkenar Üçgen");
                    break;
                
                default:
                    Console.WriteLine("Çeşitkenar Üçgen ");
                    break;
            }
            
        }
    }
}
