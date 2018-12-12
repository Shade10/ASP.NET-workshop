using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models {
    public class LinqValueCalculator : IValueCalculator {
        private IDiscoutHelper discouter;

        public LinqValueCalculator(IDiscoutHelper discoutParam) {
            discouter = discoutParam;
        }
        public decimal ValueProducts(IEnumerable<Product> products) {
            return discouter.ApplyDiscount(products.Sum(p => p.Price));
        }
    }
}