using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ASPDOTNETCARHWK.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult BrowseCars()
        {
            return View();
        }
        public ActionResult RentACar()
        {
            return View();
        }
        public ActionResult RentAVan()
        {
            return View();
        }
        public ActionResult RentAMiniBus()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
       }
        public ActionResult ContactUs()
        {
            return View();
        }
    }
}