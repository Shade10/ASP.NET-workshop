using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspWorkshop.Models;

namespace AspWorkshop.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;

            ViewBag.Greeting = hour < 17 ? "Dzień Dobry" : "Dobry Wieczór";
            return View();
        }

        public ActionResult Project()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            return View("Thanks", guestResponse);
        }
    }
}