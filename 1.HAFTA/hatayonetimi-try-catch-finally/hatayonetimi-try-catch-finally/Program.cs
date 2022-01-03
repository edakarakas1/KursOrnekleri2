using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hatayonetimi_try_catch_finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Sayı Giriniz...");
                int s = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();
                if (s==10)
                {
                    throw new ozelhatamesajı();
                }
               
            }
            catch(ozelhatamesajı fx)
            { 
                Console.WriteLine("Özel hata classındaki method çalıştı..."); 
            }
            catch (FormatException)
            {
                Console.WriteLine("Hatalı format");
            }
            catch (Exception ex)
            { Console.WriteLine("Doğru formatta girmediniz...",ex);
               
            }
            finally
            {
                //try bloğu çalışır
                //catch çalışır
                //finally her halukarda çalışır
                Console.WriteLine("finally bloğu çalıştı");
                Console.ReadLine();
            }
             Console.ReadLine();
        }
    }
}
