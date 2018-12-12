using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace EssentialTools.Models {
    public class LinqValueCalculator : IValueCalculator {
        private IDiscoutHelper discouter;
        private static int counter = 0;

        public LinqValueCalculator(IDiscoutHelper discoutParam) {
            discouter = discoutParam;
            Debug.WriteLine(string.Format("Utworzono egzemplarz {0}", ++counter));
        }
        public decimal ValueProducts(IEnumerable<Product> products) {
            return discouter.ApplyDiscount(products.Sum(p => p.Price));
        }
    }
}