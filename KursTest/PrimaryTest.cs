using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kurs.Primary;

namespace KursTest
{
    [TestClass]
    public class PrimaryTest
    {
        [TestMethod]
        public void CanISetLimit()
        {
            var primary = new PrimaryNumbers(10);
            Assert.AreEqual(primary.Limit,10);
        }

        [TestMethod]
        public void CanAlwaysPositiveLimit()
        {
            var primary = new PrimaryNumbers(-10);
            Assert.IsTrue(primary.Limit>0);
        }
        [TestMethod]
        public void CanAlwaysUpTo1()
        {
            var primary = new PrimaryNumbers(0);
            Assert.IsTrue(primary.Limit > 1);
        }
        [TestMethod]
        public void CanGet2()
        {
            var primary = new PrimaryNumbers(2);
            List<int> numbers = primary.GetNumbers();
            Assert.AreEqual(1,numbers.Count);
            Assert.AreEqual(2,numbers[0]);
        }
        [TestMethod]
        public void CanGetFirstTo10()
        {
            var primary = new PrimaryNumbers(10);
            List<int> numbers = primary.GetNumbers();
            List<int> expected = new List<int>(){2,3,5,7};
            Assert.AreEqual(4, numbers.Count);
            Assert.AreEqual(7, numbers[3]);
        }

        [TestMethod]
        public void IsPrimary()
        {
            var primary = new PrimaryNumbers(21);
            List<int> numbers = primary.GetNumbers();
            Assert.AreEqual(true,primary.isPrimary(19));
            Assert.AreEqual(false, primary.isPrimary(21));
        }
    }
}
