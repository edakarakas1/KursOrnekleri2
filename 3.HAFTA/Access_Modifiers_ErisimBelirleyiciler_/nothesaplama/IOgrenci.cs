using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nothesaplama
{
    public interface IOgrenci
    {
       
       
        int ogrenciNo { get; set; }
        string Ad { get; set; }
        string Soyad { get; set; }
        double Sınav1 { get; set; }
        double Sınav2 { get; set; }
        double ortalama { get; set; }
       
    }
}
