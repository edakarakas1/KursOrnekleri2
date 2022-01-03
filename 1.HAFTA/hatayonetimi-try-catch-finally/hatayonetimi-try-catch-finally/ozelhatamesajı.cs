using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hatayonetimi_try_catch_finally
{
   public class ozelhatamesajı:Exception
    { 
        public  ozelhatamesajı()
        {
            Console.WriteLine("Özel hata mesajı");
        }
    }
}
