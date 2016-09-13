using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using KataSupermarket;
using System;
using NUnit.Framework;


namespace KataSupermarketTest
{
    [TestFixture]
    public class CheckoutTests
    {
        private CheckOut checkout;

        private readonly Item itemA = new Item
        {
            Name = "A",
            Price = 50
        };

        private readonly Item itemB = new Item
        {
            Name = "B",
            Price = 30
        };

        private readonly PricingRule ItemARule = new PricingRule
        {
            ItemName = "A",
            ItemCount = 3,
            Total = 130
        };

        private readonly PricingRule ItemBRule = new PricingRule
        {
            ItemName = "B",
            ItemCount = 2,
            Total = 45
        };


        [SetUp]
        public void SetUp()
        {
            checkout = new CheckOut();
        }

        private void AddItems(int count, Item item)
        {
            for (int i = 0; i < count; i++)
            {
                checkout.AddItem(item);
            }
        }

        [Test]
        public void TestCheckoutZeroItemReturnsZero()
        {
            int result = checkout.CalculateTotal();
            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestCheckoutOneItemsPriceAsTotal()
        {
            AddItems(1, itemA);

            int result = checkout.CalculateTotal();
            Assert.AreEqual(50, result);
        }


        [Test]
        public void TestCheckoutWithSpecialPriceCriteriaMetReturnsSpecialPrice()
        {
            checkout.AddPricingRule(ItemARule);
            AddItems(3, itemA);
            int result = checkout.CalculateTotal();
            Assert.AreEqual(130, result);
        }

        [Test]
        public void TestCheckoutWithSpecialPriceCriteriaNotMetReturnsTotal()
        {
            checkout.AddPricingRule(ItemARule);
            AddItems(2, itemA);
            int result = checkout.CalculateTotal();
            Assert.AreEqual(100, result);
        }

        [Test]
        public void TestCheckoutWithSpecialPriceCriteriaMetAndExtraItemsReturnsSpecialPricePlusExtraItemsTotal()
        {
            checkout.AddPricingRule(ItemARule);
            AddItems(4, itemA);
            int result = checkout.CalculateTotal();
            Assert.AreEqual(180, result);
        }

        [Test]
        public void TestCheckoutWithMultipleGroupsOfItemsWithSpecialPriceCriteriaMet()
        {
            checkout.AddPricingRule(ItemARule);
            checkout.AddPricingRule(ItemBRule);
            AddItems(4, itemA);
            AddItems(3, itemB);
            int result = checkout.CalculateTotal();
            Assert.AreEqual(255, result);
        }

        //[Test]
        //[ExpectedException(typeof(ArgumentException))]
        //public void TestAddingPricingRuleWithoutNameThrowsException()
        //{
        //    checkout.AddPricingRule(new PricingRule
        //    {
        //        ItemCount = 2,
        //        Total = 45
        //    });
        //}
    
    }
}
