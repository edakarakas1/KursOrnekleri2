using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım
{
    public class Calisan:Egitmen
    {
       
        public Calisan()
        {
            Console.WriteLine("Çalışan clasının yapıcı metodu ");
        }
        public string gorev { get; set; }
    }
}
