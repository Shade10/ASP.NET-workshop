using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _myAsp.Models;

namespace _myAsp.Controllers {
    public class HomeController : Controller {
        // GET: Home
        public ActionResult Index() {
            return View();
        }

        [HttpGet]
        public ViewResult Rsvp() {
            return View();
        }

        [HttpPost]
        public ViewResult Rsvp(GuestResponse guestResponse) {
            if (ModelState.IsValid) {
                return View("Thanks", guestResponse);
            } else return View(string.Format("rsvp"));
        }
    }
}