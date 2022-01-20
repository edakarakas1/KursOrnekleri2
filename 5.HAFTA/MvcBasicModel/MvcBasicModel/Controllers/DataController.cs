using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBasicModel.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        public ActionResult Webmaster()
        {
            Master master = new Master();
            master.id = 1001;
            master.Ad = "eda";
            master.Soyad = "karakas";
            //1.yol viewbag
            ViewBag.id = master.id;
            ViewBag.Ad = master.Ad;
            ViewBag.Soyad = master.Soyad;
            ViewBag.Master = master;


            //return View();
            //2.yol Model göndermek .Model demek datanın kendisi
            return View(master);
        }

        public ActionResult Personel()
        {
            List<Personel> plist = new List<Personel>();
            Personel p = new Personel();
            p.id = 1;
            p.Ad = "Sena";
            p.Soyad = "Mutlu";
            p.Maas = 5000;
            plist.Add(p);

            Personel p2 = new Personel();
            p2.id = 2;
            p2.Ad = "Eda";
            p2.Soyad = "Şahin";
            p2.Maas = 5000;
            plist.Add(p2);

            Personel p3 = new Personel();
            p3.id = 3;
            p3.Ad = "Gül";
            p3.Soyad = "Yılmaz";
            p3.Maas = 5000;
            plist.Add(p3);
            return View(plist);
        }
        public ActionResult Adres()
        {
            List<Adres> alist = new List<Adres>();
            Adres a = new Adres();
            a.id = 34;
            a.sehirismi = "İstanbul";
            

            Adres a1 = new Adres();
            a1.id = 35;
            a1.sehirismi = "İzmir";
            return View(alist);
        }
    }
}