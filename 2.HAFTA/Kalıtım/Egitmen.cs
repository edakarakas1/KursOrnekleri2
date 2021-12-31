using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım
{
    public class Egitmen:Ogrenci
    {
        public Egitmen() {
            Console.WriteLine("eğitmen clasının yapıcı metodu");
        }
        public string brans { get; set; }
    }
}
