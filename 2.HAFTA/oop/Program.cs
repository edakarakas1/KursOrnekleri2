using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Musteri --tc,ad,soyad,cinsiyet vb.
            //satış temsilcisi --tc,sicilnumarası,isim,soyisim,cinsiyet vb.
            //araç --marka,model ,model yıl,km,yakıt tipi ,vites tipi
            //teklif --teklif id,fiyat,müşteri,satıci
            //sipariş --sipariş no,teklif ,fiyat
            //fatura --fatura no,teklif,musteri...

            /* Musteri M1 = new Musteri();
             M1.TcKimlikNumarası = "12213231245";
             M1.isim = "eda";
             M1.soyisim = "karakas";
             M1.cinsiyet = 777100102;

             Musteri M2 = M1;
             M2.isim = "selin";
             M1.TcKimlikNumarası = "12222112211";
             M2 = null;
             M1 = null;
             string isim = M2.isim;*/
            /*m2 ve m1 e sen artık o noktaya bakma dedim Heap bölgede o noktayı tutan bir değer
            kalmadığında pointersız kalır ve ramden düşer.Garbage collector bunu alır ve silir.*/
            //string isim = M2.isim;
            /*bunu çalıştırdığımda hata alırım .m2 nin müşteri nesnesi olduğunu
             biliyorum ama newlemediğim için buna ulaşamam */


            //Musteri M1 = new Musteri();parantez varsayılan 
            Musteri M1 = new Musteri("12213231245", "leyla");
            M1.TcKimlikNumarası = "12213231245";
            M1.isim = "eda";
            M1.soyisim = "karakas";
            M1.cinsiyet = 777100102;
          bool kontrol=  M1.MusteriKontrol();



            /*araç adında class oluştur
             * marka
             * model
             * model_yıl
             * km
             * yakıt_tipi
             * vites_tipi
             * alış_fiyat
             * satış_fiyat
             * max_indirim
             * fiyat
            
            arac clasının 4tane overloadu olucal 
            1-varsayilan boş hali
            2-marka,model
            3-marka,model,model_yıl
            4-marka,model,model_yıl,km

            void BilgileriGoruntule()---cw ekranda göster
            void fiyatAta(fiyat)---fiyat=satış_fiyatı-indirim tutarı---buradan çıkan fiyat 
            değeri kullanıcının girdiği fiyattan küçükse geçersiz fiyat desin Değilse fiyatı güncellesin
             */


            Arac M3 = new Arac("opel","corsa",2020,50000);
           
            M3.Alisfiyati = 28000;
            M3.Satisfiyati = 32000;
            M3.MaxindirimTutari = 1500;
            M3.BilgileriGoruntule();
            M3.FiyatAta(30600);
           

            Console.ReadLine();


        }
    }
    /*class Musteri {
    classı burada da tanımlayabiliriz
    }*/
}
