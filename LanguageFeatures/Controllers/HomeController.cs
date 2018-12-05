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
                Category = "Sporty Wodne"
            };
            return View("Index", (object) String.Format("Kategoria: {0}", myProduct.Category));
        }

        public ViewResult CreateCollection() {
            string[] stringArray = { "jabłko", "pomarańcza", "gruszka" };
            List<int> intList = new List<int> { 10, 20, 30, 40 };

            Dictionary<string, int> myDict = new Dictionary<string, int>
            {
                {"jbłko", 10 }, {"pomarańcza", 20}, {"gruszka", 30}
            };

            return View("Index", (object) stringArray[1]);
        }

        public ViewResult UseExtension() {
            ShoppingCart cart = new ShoppingCart {
                Products = new List<Product>
                {
                    new Product {Name = "Kajak", Price = 275M},
                    new Product {Name = "Kamizelka ratunkowa", Price = 48.95M},
                    new Product {Name = "Pika nożna", Price = 19.50M},
                    new Product {Name = "Flaga narożna", Price = 34.95M},
                }
            };
            decimal cartTotal = cart.TotalPrices();

            return View("Index", (object) String.Format("Razem: {0:c}", cartTotal));
        }

        public ViewResult UseExtensionEnumerable() {
            IEnumerable<Product> products = new ShoppingCart {
                Products = new List<Product>
                {
                    new Product {Name = "Kajak", Price = 275M},
                    new Product {Name = "Kamizelka ratunkowa", Price = 48.95M},
                    new Product {Name = "Pika nożna", Price = 19.50M},
                    new Product {Name = "Flaga narożna", Price = 34.95M},
                }
            };

            Product[] productArray =
            {
                new Product {Name = "Kajak", Price = 275M},
                new Product {Name = "Kamizelka ratunkowa", Price = 48.95M},
                new Product {Name = "Pika nożna", Price = 19.50M},
                new Product {Name = "Flaga narożna", Price = 34.95M},
            };

            decimal cartTotal = products.TotalPrices();
            decimal arrayTotal = products.TotalPrices();

            return View("Index", (object) String.Format("Razem koszyk: {0}, razem talica: {1}", cartTotal, arrayTotal));
        }

    }
}