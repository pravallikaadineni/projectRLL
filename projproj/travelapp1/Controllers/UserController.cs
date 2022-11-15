using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace travelapp1.Controllers
{
    public class UserController : Controller
    {
        Operations cd = new Operations();
        // GET: User
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult UserLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserLogin(FormCollection c)
        {
            string s = c["Email"].ToString();
            string k = c["Password"].ToString();
            bool k1 = false;
            foreach (var item in cd.GetUser())
            {
                if (item.Email == s && item.Password == k)
                {
                    TempData["user1"] = item;
                    Session["u1"] = item;
                    k1 = true;
                }
            }
            if (k1)
            {
                return RedirectToAction("Dashboard");

            }
            else
            {
                ViewBag.Message = "Invalid Credentials..Try Again";
                return View();
            }


        }
        public ActionResult Profile()
        {
            User s = (User)TempData["user1"];
            TempData["user1"] = s;
            return View(s);
        }
        [HttpPost]
        public ActionResult Profile(User s)
        {
            try
            {
                string k = "~/Images/";
                s.Photo = k + s.Photo;
                cd.PutUser(s.UserId, s);
                return RedirectToAction("Dashboard");
            }
            catch
            {
                return View();
            }


        }
        public ActionResult MyAlbums()
        {
            User k = (User)TempData["user1"];
           TempData["user1"] = k;
            List<TravelDetail> cs = cd.GetDetails();
            cs = cs.Where(x => x.UserId == k.UserId).ToList();
            return View(cs);


        }
        public ActionResult VisitingPlaces(int id)
        {
            List<PlacesToVisit> k = cd.GetPlaces();
            TravelDetail k1 = cd.GetDetails(id);
            
            User s = (User)TempData["user1"];
            TempData["user1"] = s;
           TempData["loc"]  = k1.Location;

            k = k.Where(x => (x.UserId == s.UserId )&& (x.Location.Trim() == k1.Location.Trim())).ToList();
            return View(k);

        }
        public ActionResult AddPlace()
        {
            User s = (User)TempData["user1"];
            TempData["user1"] = s;
            

            PlacesToVisit place = new PlacesToVisit();
          
            place.UserId = s.UserId;
            place.Location  = TempData["loc"].ToString();
            TempData["loc"] = place.Location;


            return View(place);
        }
        [HttpPost]
        public ActionResult AddPlace(PlacesToVisit v)
        {
            try
            {
                string k = v.Location;
                v.PlaceImage = "~/Images/" + v.PlaceImage;
                cd.PostPlace(v);
                return RedirectToAction("MyAlbums");

            }
            catch
            {
                return View();

            }


        }
        public ActionResult EditPlace(int id)
        {
            PlacesToVisit k = cd.GetPlaces(id);
            return View(k);
        }
        [HttpPost]
        public ActionResult EditPlace(int id, PlacesToVisit k)
        {
            try
            {
                cd.PutPlace(id, k);
                return RedirectToAction("VisitingPlaces");

            }
            catch
            {
                return View();
            }
        }
        public ActionResult PlaceDetails(int id)
        {
            PlacesToVisit k = cd.GetPlaces(id);
            return View(k);
        }
        public ActionResult DeletePlace(int id)
        {
            PlacesToVisit k = cd.GetPlaces(id);
            return View(k);
        }
        [HttpPost]
        public ActionResult DeletePlace(int id, FormCollection c)
        {
            try
            {
                cd.DeletePlace(id);
                return RedirectToAction("VisitingPlaces");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult AddAlbum()
        {
            User s = (User)TempData["user1"];
            TempData["User1"] = s;
            TravelDetail k = new TravelDetail();
            k.UserId = s.UserId;
            return View(k);

        }
        [HttpPost]
        public ActionResult AddAlbum(TravelDetail k)
        {
            try
            {
                cd.PostDetails(k);
                return RedirectToAction("MyAlbums");

            }
            catch
            {
                return View();
            }
        }
        public ActionResult EditAlbum(int id)
        {
            TravelDetail k = cd.GetDetails(id);
            return View(k);
        }
        [HttpPost]
        public ActionResult EditAlbum(int id, TravelDetail k)
        {
            try
            {
                cd.PutDetails(id, k);
                return RedirectToAction("MyAlbums");

            }
            catch
            {
                return View();
            }
        }
        public ActionResult AlbumDetails(int id)
        {
            TravelDetail k = cd.GetDetails(id);
            return View(k);
        }
        public ActionResult DeleteAlbum(int id)
        {
            TravelDetail k = cd.GetDetails(id);
            return View(k);
        }
        [HttpPost]
        public ActionResult DeleteAlbum(int id, FormCollection c)
        {
            try
            {
                cd.DeleteDetails(id);
                return RedirectToAction("MyAlbums");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Explore()
        {
            User s = (User)TempData["user1"];
            TempData["User1"] = s;
            List<PlacesToVisit> k = cd.GetPlaces();
            k=k.Where(x=>x.UserId != s.UserId).ToList();
            return View(k);

        }
    }
}