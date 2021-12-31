using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrn
{
    internal class Program
    {
        /*
 console proje
2tane ınterface olucak
---Iaraba :marka, model,model yili,sanzıman,özellikoku adında bir metod
Inumara:yildiz int tipinde 
Araba sınıfı clası 2 sindende miras alıcak.Model yılı 2005 ten küçükse default deger 2005değilse value alanı
kullanıcının girdiği değer olucak
Araba clasında yıldız propertysi 5ten büyük girildiyse 5olarak atansın değilse kullanıcının girdiği değer
value ya atansın.
ozellikOku metodunda da --Araç Özelliklerimiz+Markası:....+Şanzıman Türü:.......+ModelYılı:........
 */
        static void Main(string[] args)
        {
            Arabaclass a = new Arabaclass();
            a.marka = "Cabby";
            a.model = "Minibüs";
            a.modelYili = 2004;
            a.sanzıman = "Otamatik";
            a.yildiz = 8;
            a.ozellikOku();
            Console.ReadLine();
        }
    }
}
