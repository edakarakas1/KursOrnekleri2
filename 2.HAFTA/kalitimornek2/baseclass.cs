using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalitimornek2
{
    public class baseclass
    {public static int sayac=1;//ilk oluştuğunda 1 değerini otomatik al
        public baseclass()
        {
            _id = sayac;
            sayac = sayac + 1;

        }
        private int _id;
        public int id { get {return _id; } private set {; } }   //kullanıcı atayamasın 1 1 artacak şekilde kendi oluşsun
        private string _barkod;
        public string Barkod { get {return _barkod; } 
            set {
                bool konrolislemi = sanaldatabase.dbBarkodKontrol(value);
                if (!konrolislemi)//degeri sanal db de yoksa
                {
                    _barkod = value;
                }
                else
                {
                    Console.WriteLine("sanal database içerisinde bu barkod girilmiştir");
                }

                ; } 
        }
        public DateTime OlusturmaTarihi { get; set; }
        public int OlusturanKullanici { get; set; }
        public int GuncellemeTarih { get; set; }
        public int GuncelleyenKullanici { get; set; }
        public bool silindi { get; set; }
    }
}
