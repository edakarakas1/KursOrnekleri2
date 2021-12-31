using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass2
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             * database |uygulama
             tablo musteri
            int ad
            musterino guid
            isim nvarchar(50)
            soyisim nvarchar(50)
            dagumtarihi datetime
             */

            genericRepository<Musteri> repositorymusteri=new genericRepository<Musteri>();
           List<Musteri>musteriliste= repositorymusteri.Getir();
            repositorymusteri.yenikayitekle(null);

            genericRepository<Urun> repositoryurun=new genericRepository<Urun>();
            repositoryurun.Getir();
            repositoryurun.yenikayitekle(null);
           // genericRepository<int>d=new genericRepository<int>();
        }
    }
}
