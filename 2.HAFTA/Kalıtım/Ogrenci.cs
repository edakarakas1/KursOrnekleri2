using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım
{
    public /*sealed*/ class Ogrenci
    {
        //sealed keywordu gelirse o nesnenin kalıtılmasına izin vermemil olorum 
        public Ogrenci()
        {
            Console.WriteLine("ögrenci clasının yapıcı metodu");
        }
        public int id { get; set; }
        public string Ad { get; set; }
    }
}
