using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cokboyutludiziler_multidimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] bolgeler = new string[7, 3]
            {   { "İstanbul","Çanakkale","Bursa"},
                { "İzmir","Manisa","Muğla"},   
                { "Antalya","Isparta","Mersin"},
                { "Konya","Ankara","Eskişehir"},
                { "zonguldak","Trabzon","Rize"},
                { "Gaziantep","Mardin","Şanlıurfa"},
                { "Ağrı","Hakkari","Van"}
        };
            for (int i = 0; i <=bolgeler.GetUpperBound(0); i++)
            {
                for (int j = 0; j <=bolgeler.GetUpperBound(1); j++)
                {
                    Console.WriteLine(bolgeler[i,j]);

                }
                Console.WriteLine("*************");
            }
            Console.ReadLine();
        }
    }
}
