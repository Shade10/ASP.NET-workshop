﻿using System;
using EssentialTools.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EssentialTools.Tests {
    [TestClass]
    public class UnitTest1 {
        private IDiscoutHelper getTestObject() {
            return new MinimumDiscountHelper();
        }
        [TestMethod]
        public void Discount_Above_100() {
            IDiscoutHelper target = getTestObject();
            decimal total = 200;

            var discountedTotal = target.ApplyDiscount(total);

            Assert.AreEqual(total * 0.9M, discountedTotal);
        }

        [TestMethod]
        public void Discount_Between_10_And_100() {
            IDiscoutHelper target = getTestObject();

            decimal TenDollarDiscount = target.ApplyDiscount(10);
            decimal HundredDollarDiscount = target.ApplyDiscount(100);
            decimal FiftyDollarDiscount = target.ApplyDiscount(50);

            Assert.AreEqual(5, TenDollarDiscount, "rabat w wysokości 10 zł jest nieprawidłowy");
            Assert.AreEqual(95, TenDollarDiscount, "rabat w wysokości 100 zł jest nieprawidłowy");
            Assert.AreEqual(45, TenDollarDiscount, "rabat w wysokości 50 zł jest nieprawidłowy");
        }

        [TestMethod]
        public void Discount_Less_Than_10() {
            IDiscoutHelper target = getTestObject();

            decimal discount5 = target.ApplyDiscount(5);
            decimal discount0 = target.ApplyDiscount(0);

            Assert.AreEqual(5, discount5);
            Assert.AreEqual(0, discount0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Discount_Negative_Total()
        {
            IDiscoutHelper target = getTestObject();

            target.ApplyDiscount(-1);
        }
    }
}
