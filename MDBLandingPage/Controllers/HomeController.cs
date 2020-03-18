using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MDBLandingPage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.FullPageIntro = true;
            ViewBag.RenderCarousel = false;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.FullPageIntro = false;
            ViewBag.RenderCarousel = false;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            ViewBag.FullPageIntro = false;
            ViewBag.RenderCarousel = false;
            return View();
        }

        public ActionResult Buttons()
        {
            ViewBag.FullPageIntro = false;
            ViewBag.RenderCarousel = true;
            return View();
        }
    }
}