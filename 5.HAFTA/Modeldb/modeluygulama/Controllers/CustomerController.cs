using modeluygulama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace modeluygulama.Controllers

{
    public class CostomerController : Controller

    { 
      NorthwindEntities db = new NorthwindEntities();
    public ActionResult Liste()
    {
        MultiModel model = new MultiModel();
        model.elist=db.Employees.ToList();
        model.clist = db.Customers.ToList();
        return View(model);
    }
        public ActionResult listele()
        {
            MultiModel model = new MultiModel();
            model.elist = db.Employees.ToList();
            model.clist = db.Customers.ToList();
            return View(model);

        }
    }
}