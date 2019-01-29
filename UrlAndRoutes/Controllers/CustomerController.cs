using System;
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

        [Route("Users/Add/{user}/{id:int}")]
        public string Create(string user, int id)
        {
            return string.Format("Użytkownik: {0}, ID: {1}", user, id);
        }

        [Route("Users/Add/{user}/{password:alpha:length(6)}")]
        public string ChangePass(string user, string password) {
            return string.Format("Metoda ChangePass - użytkownik: {0}, hasło: {1}", user, password);
        }

        public ActionResult List() {
            ViewBag.Controller = "Customer";
            ViewBag.Action = "List";

            return View("ActionName");
        }


    }
}
