using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers {
    public class HomeController : Controller {
        // GET: Home
        public string Index() {
            return "Jakiś text w indexie";
        }

        public ViewResult AutoProperty() {
            Product myProduct = new Product();

            myProduct.Name = "Kajak";
            string productName = myProduct.Name;
            return View("Index", (object) String.Format("Nazwa produktu: {0}", productName));
        }

        public ViewResult CreateProduct() {
            Product myProduct = new Product {
                ProductId = 100,
                Name = "Kajak",
                Description = "łódka jednoosobowa",
                Price = 275M,
                category = "Sporty Wodne"
            };
            return View("Index", (object) String.Format("Kategoria: {0}", myProduct.category));
        }

    }
}