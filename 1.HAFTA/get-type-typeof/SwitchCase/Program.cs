using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            YenidenBasla:
            Console.WriteLine("Doğum yılını giriniz");
            int yil = Convert.ToInt32(Console.ReadLine());
            int yas = DateTime.Now.Year - yil;
            //Console.WriteLine(yas);

            switch (yas)
            {
                case int kontrol when yas>= 18:
                    Console.WriteLine($"Yaşınız {yas} Ehliyet alabilirsiniz");
                    break;
                case int kontrol when yas<18:
                    Console.WriteLine($"Ehliyet alamazsınız");
                    goto YenidenBasla;
                default:
                    break;
            }

            Console.ReadLine();  
        }
    }
}
