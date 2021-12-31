using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSamle
{
    internal class Program
    { /*3tane class olacak 
            ---BasePersonel absstract class olucak içerisinde Ad,Id,Soyad properyleri olacak,
            AdSoyad isminde bir method tanımlanacak bu geriye isim ve soy ismi birleştirip gönderilecek,
            AylıkMaas isminde abstract int geri değer donduren bir method olacak
            ---FulltimePersonel  : basepersonelde kalıtım  alacak içerisinde yıllık maaş propertysi olacak,
            aylık maaş metodu hesaplaması yıllıkmaas/12 olarak tanımlanacak 
            ---SözleşmeliPersonel : Basepersonel kalıtım alıcak ,içerisinde saatli ödeme ve çalışma süresi
            adında int property yer alacak.Aylık maas metodu saatliodeme*çalışma süresi
            olarak hesaplanacak
             */
        static void Main(string[] args)
        {
            FullTimePersonel fltm=new FullTimePersonel();
            fltm.Id = 100;
            fltm.Ad = "metin";
            fltm.Soyad = "şen";
            fltm.yillikMaas = 40000;
            Console.WriteLine(fltm.AdSoyad());
            Console.WriteLine("Full timr maas="+fltm.AylikMaas());
            
            SozlesmeliPersonel s = new SozlesmeliPersonel();
            s.Id = 101;
            s.Ad = "melek";
            s.Soyad = "sapmaz";
            s.calısmaSuresi = 20;
            s.saatliOdeme = 40;
            Console.WriteLine(s.AdSoyad());
            Console.WriteLine("Sözleşmeli personel maaş=" +s.AylikMaas());
        }
    }
}
