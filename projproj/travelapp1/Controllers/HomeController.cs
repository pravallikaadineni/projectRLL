using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;

namespace travelapp1.Controllers
{
    public class HomeController : Controller
    {
      Operations cd= new Operations();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User k)
        {
            try
            {
                k.Photo = "~/Images/" + k.Photo;
                cd.PostUser(k);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


    }
}