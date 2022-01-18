using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ActionResultSample.Controllers
{
    public class HttpController : Controller
    {//Http durum kodlarını report etmek için kullanılır
        // GET: Http
        public ActionResult Index()
        {
            // return new HttpStatusCodeResult(HttpStatusCode.BadRequest);//502hatası gelecek,
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest,"Bad Gateway hatası");
        }
        public HttpUnauthorizedResult Index2()
        {
            // return new HttpUnauthorizedResult();
            return new HttpUnauthorizedResult("Yetkili Değilsiniz");
        }
        public HttpNotFoundResult Index3()
        {
            //return HttpNotFound();//sayfa bulunamadı hatası
            return HttpNotFound("Sorry!This page not found");
        }
    }
}