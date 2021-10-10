using NUnit.Framework;
using System.Collections.Generic;

namespace EntryTest.UnitTestCore
{
    public class PromotionalOfferTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetPromotionalPrice_TestCase1_Returns100()
        {
            var promotionalOffer = new PromotionalOffer();
            List<Product> newProdList = new List<Product>();
            newProdList.Add(new Product { prodType = "A", NoOfUnit =1 });
            newProdList.Add(new Product { prodType = "B", NoOfUnit =1 });
            newProdList.Add(new Product { prodType = "C", NoOfUnit =1 });
            newProdList.Add(new Product { prodType = "D", NoOfUnit = 0 });

            var result = promotionalOffer.GetPromotionalPrice(newProdList);
            Assert.AreEqual(result, 100);
            Assert.That(result == 100);
            Assert.Pass("Test Case1 Passed");
        }

        [Test]
        public void GetPromotionalPrice_TestCase1_Returns370()
        {
            var promotionalOffer = new PromotionalOffer();
            List<Product> newProdList = new List<Product>();
            newProdList.Add(new Product { prodType = "A", NoOfUnit = 5 });
            newProdList.Add(new Product { prodType = "B", NoOfUnit = 5 });
            newProdList.Add(new Product { prodType = "C", NoOfUnit = 1 });
            newProdList.Add(new Product { prodType = "D", NoOfUnit = 0 });

            var result = promotionalOffer.GetPromotionalPrice(newProdList);
            Assert.AreEqual(result, 370);
            Assert.Pass("Test Case1 Passed");
        }

        [Test]
        public void GetPromotionalPrice_TestCase1_Returns280()
        {
            var promotionalOffer = new PromotionalOffer();
            List<Product> newProdList = new List<Product>();
            newProdList.Add(new Product { prodType = "A", NoOfUnit = 3 });
            newProdList.Add(new Product { prodType = "B", NoOfUnit = 5 });
            newProdList.Add(new Product { prodType = "C", NoOfUnit = 1 });
            newProdList.Add(new Product { prodType = "D", NoOfUnit = 1 });

            var result = promotionalOffer.GetPromotionalPrice(newProdList);
            Assert.AreEqual(result, 280);
            Assert.Pass("Test Case1 Passed");
        }
    }
}