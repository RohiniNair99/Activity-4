using Microsoft.VisualStudio.TestTools.UnitTesting;
using Activity4BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity4BL.Tests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        public void PProductTest()
        {
            Product p = new Product();
            Product p1 = new Product();
            string expected = "P1001";
            string expected1 = "P1002";
            string actual = p.ProductId;
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected1, p1.ProductId);
        }

        [TestMethod()]
        public void NProductTest()
        {
            Product p = new Product();
            Product p1 = new Product();
            string expected = "P1001";
            Assert.AreNotEqual(expected, p1.ProductId);
        }
    }
}