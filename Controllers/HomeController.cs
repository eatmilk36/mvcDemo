using Dapper;
using mvcDEMO.Attributes;
using mvcDEMO.Models.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace mvcDEMO.Controllers
{
    public class HomeController : Controller
    {
        [TestDemoAttribute("", 0)]
        public ActionResult Index()
        {
            dapperHelper dh = new dapperHelper();
            IEnumerable<CategoriesViewModel> ViewModel = dh.db.Query<CategoriesViewModel>("select * from Categories");
            return View(ViewModel.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Valid = "";
            return View();
        }

        //[HttpPost]
        //public ActionResult About()
        //{
        //    //轉頁用
        //    return View();
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AboutCheck(CategoriesViewModel viewModel)
        {
            Thread.Sleep(2000);
            dapperHelper dh = new dapperHelper();
            if (ModelState.IsValid)
            {
                //int check = dh.db.Execute("insert into Categories (CategoryName,Description) values (@CategoryName,@Description)"
                //    , new { viewModel.CategoryName, viewModel.Description });

                //if (check > 0)
                return Content(JsonConvert.SerializeObject(new { ststus = true, message = string.Empty }));
            }

            //ViewBag.Valid = "帳號或密碼錯誤";
            return Content(JsonConvert.SerializeObject(new { ststus = false, message = "驗證失敗" }));
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}