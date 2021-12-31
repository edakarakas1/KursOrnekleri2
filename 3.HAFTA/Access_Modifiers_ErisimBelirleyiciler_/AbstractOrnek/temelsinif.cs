using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOrnek
{
    public abstract class temelsinif
    {
        public DateTime kayittarihi { get; set; }
        public DateTime guncellemetarihi { get; set; }
        public temelsinif()
        {
            kayittarihi = DateTime.Now;
            guncellemetarihi = DateTime.Now;
        }
        public void test()
        {
            Console.WriteLine("temelsınıf=>sınıf");
        }
        public abstract void testAbstract();//sadece methodun imzası yer alır
    }
}
