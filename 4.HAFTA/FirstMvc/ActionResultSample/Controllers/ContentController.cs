using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionResultSample.Controllers
{
    public class ContentController : Controller
    {//Kullanıcı tanımlı bir değer return etmek için kullanılır
        // GET: Content
        public ContentResult Index()
        {
            // return Content("eda karakas");
            return Content("eda karakas", "text/html; charset = utf - 8") ;
        }
        public ContentResult Index2()
        {
            // return Content("<b>eda karakas</b>");
            return Content("<b>eda karakas</b>", "text/plain");
        }
    }
}