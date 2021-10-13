using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MOILSUROK2.Controllers
{
    public class HomeController : Controller
    {
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
        public ActionResult Login()
        {
            ViewBag.Message = "로그인을 먼저해주세요";

            return View();
        }
        public ActionResult AddMember()
        {


            return View();
        }
        public ActionResult Member()
        {
           

            return View();
        }

        public ActionResult AddNotic()
        {


            return View();
        }
        public ActionResult Notic()
        {
          

            return View();
        }

        public ActionResult Calendar()
        {

            return View();
        }
        public ActionResult AddCalendar()
        {

            return View();
        }

    }
}