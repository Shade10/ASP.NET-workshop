using System;
using EssentialTools.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EssentialTools.Tests {
    [TestClass]
    public class UnitTest1 {
        private IDiscoutHelper getTestObject() {
            return new MinimumDiscountHelper();
        }
        [TestMethod]
        public void Discount_Above_100()
        {
            IDiscoutHelper target = getTestObject();
            decimal total = 200;

            var discountedTotal = target.ApplyDiscount(total);

            Assert.AreEqual(total * 0.9M, discountedTotal);
        }
    }
}
