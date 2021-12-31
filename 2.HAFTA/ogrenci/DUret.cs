using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenci
{
    internal class DUret
    {

        string[] Adlar = { "eda", "gül", "büşra", "selin", "şahin", "zeynep" };
        string[] Soyadlar = { "karakas", "yılmaz", "şen", "muştu", "bal" };
        string[] Sehirler = { "İstanbul", "Çanakkale", "İzmir", "Ankara", "Eskişehir" };
        static Random rnd = new Random();
        public string Getname()
        {
            int sayi = rnd.Next(0, Adlar.Length);
            return Adlar[sayi];
        }
        public string GetSurname()
        {
            int sayi = rnd.Next(0, Soyadlar.Length);
            return Soyadlar[sayi];
        }
        public string City()
        {
            int sayi = rnd.Next(0, Sehirler.Length);
            return Sehirler[sayi];
        }
        public DateTime GetBackDate(int year)
        {
            year = -1 * rnd.Next(0, year);
            return DateTime.Now.AddYears(year);
        }
        public DateTime ForwadDate(int year)
        {
            year = rnd.Next(0, year);
            return DateTime.Now.AddYears(year);

        }
    }
}
