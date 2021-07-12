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
    public class PurchaseTests
    {
        [TestMethod()]
        public void PurchaseTest()
        {

        }

        [TestMethod()]
        public void PPurchaseTest1()
        {
            Purchase p = new Purchase();
            Purchase p1 = new Purchase();
            string expected = "B1001";
            string expected1 = "B1002";
            Assert.AreEqual(expected, p.PurchaseId);
            Assert.AreEqual(expected1, p1.PurchaseId);
        }


        [TestMethod()]
        public void NPurchaseTest1()
        {
            Purchase p = new Purchase();
            Purchase p1 = new Purchase();
            string expected = "B1001";
            Assert.AreNotEqual(expected, p1.PurchaseId);
        }

        [TestMethod()]
        public void PCalculateBillAmountTest()
        {
            Product p = new Product();
            Purchase pd = new Purchase();
            p.Price = 12.30D;
            int quantity = 3;
            double expected = 37.50885D;
            Assert.AreEqual(expected, pd.CalculateBillAmount(p, quantity));
        }

        [TestMethod()]
        public void NCalculateBillAmountTest()
        {
            Product p = new Product();
            Purchase pd = new Purchase();
            p.Price = 12.30D;
            int quantity = 3;
            double expected = 37;
            Assert.AreNotEqual(expected, pd.CalculateBillAmount(p, quantity));
        }
    }
}