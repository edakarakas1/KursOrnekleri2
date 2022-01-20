using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Workingwithmodel.Models;

namespace Workingwithmodel.Controllers
{
    public class ProductController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Product
        public ActionResult Index()
        {
            //List<Categories> c = db.Categories.ToList();
            //List<Products> p = db.Products.ToList();
            //List<Customers> cu = db.Customers.ToList();
         
            var model = new ProductViewModel
            {
                Clist = db.Categories.ToList(),
                Plist = db.Products.ToList()
            };
            return View(/*"Index2"*/model);
        }
        public ActionResult Demo()
        {
            return View(model:"eda karakas");
        }
    }
}