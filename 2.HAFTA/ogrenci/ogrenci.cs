using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenci
{
    public class ogrenci
    {
        public int Id { get; set; }
        public string ad
        { 
            get; //database veya farklı veri kaynağı ...class ı çağıran programcıya görderdiğimiz kısım yani veriyi okuyabileceğim
            
            set; //dış dünyadan alınan datanın içeride private olarak saklanan field içeriine atandığı kısım**public oldğunda güncelleme yapar
        }
        //kapsülleme yapılmamış alan 
        public string soyad { get; set; }
        public string DogumYeri { get; set; }
        public DateTime DogumTarihi { get; set; }
        public DateTime KursBitisTarihi { get; set; }

    }
}
