using mvcDEMO.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcDEMO.Controllers
{
    public class JeterController : Controller
    {
        // GET: Jeter
        public ActionResult Index(string id = "test")
        {
            return View();
        }

        public ActionResult One(string productId)
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult One(CategoriesViewModel model)
        //{
        //    return View();
        //}
    }
}