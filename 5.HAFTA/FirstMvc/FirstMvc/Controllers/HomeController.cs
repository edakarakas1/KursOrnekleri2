using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        //public string Index()
        //{
        //    return "Merhaba Dünya";
        //}

        public ActionResult Deneme()
        {
            return View();
        }
        //public string Merhaba()
        //{
        //    return "Merhaba Dünya";
        //}
    }
}