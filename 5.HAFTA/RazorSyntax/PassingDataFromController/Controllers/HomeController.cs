using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PassingDataFromController.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.message = "viewbagden gelen mesaj";
            ViewData["mesaj"] = "Viewdatadan gelen mesaj";
            ViewBag.numbers=new[] { 1,2,5,7};
            TempData["message"] = "tempdatadan mesaj";

            // return View();
            return RedirectToAction("Index2");
        }
        public ActionResult Index2()//bu kodları farklı sayfa da görebilmek için yönlendirdik.

        //Bu yönledirme ile ındex i çalıştırdıktan sonra ındex2 ye ulaşabiliriz. ındex2 den çalıştırdığımızda ulaşamayız.
        //yölnedşrmelerde sadece tempdata verisini kaybetmiyor diğerleri verilerini kaybediyor.
        {
            return View();
        }
       
    }
}