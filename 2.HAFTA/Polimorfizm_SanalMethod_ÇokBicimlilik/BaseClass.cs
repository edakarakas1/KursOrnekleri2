using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm_SanalMethod_ÇokBicimlilik
{
    public class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("base class");
        }

        public virtual void ekranaYaz(string data)
        {
            Console.WriteLine(data);
        }
    }
}
