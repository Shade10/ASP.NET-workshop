using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models {
    public class Discount {

    }

    public interface IDiscoutHelper {
        decimal ApplyDiscount(decimal totalParam);
    }

    public class DefaultDiscountHelper : IDiscoutHelper {
        public decimal ApplyDiscount(decimal totalParam) {
            return (totalParam - (10m / 100m * totalParam)); 
        }
    }
}