﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UrlAndRoutes.Controllers {
    public class CustomerController : Controller {
        // GET: Customer
        [Route("Test")]
        public ActionResult Index() {
            ViewBag.Controller = "Customer";
            ViewBag.Action = "Index";

            return View("ActionName");
        }

        [Route("Users/Add/{user}/{id}")]
        public string Create(string user, int id)
        {
            return string.Format("Użytkownik: {0}, ID: {1}", user, id);
        }

        public ActionResult List() {
            ViewBag.Controller = "Customer";
            ViewBag.Action = "List";

            return View("ActionName");
        }


    }
}
