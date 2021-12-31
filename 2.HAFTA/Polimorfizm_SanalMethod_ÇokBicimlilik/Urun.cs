using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm_SanalMethod_ÇokBicimlilik
{
    public class Urun:BaseClass
    {

        public Urun()
        {
            Console.WriteLine("ürün");
        }
        public override void ekranaYaz(string data)
        {
            Console.WriteLine("ürün=>"+data);
        }
    }
}
