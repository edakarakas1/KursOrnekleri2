using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumkullanimi
{
    public class SanalDatabase
    {
        ArrayList db = new ArrayList();
        public CustomerReturnValue musteriyenikayitekle(Customer c)
        {
            //kontroller
            db.Add(c);
            return CustomerReturnValue.kayitbasarili;
        }
    }
}
