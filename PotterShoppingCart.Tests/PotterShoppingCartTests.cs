using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterShoppingCart;

namespace PotterShoppingCart.Tests
{
    [TestClass]
    public class PotterShoppingCartTests
    {
        [TestMethod]
        public void Buy_ep1_and_no_buy_other_should_be_100()
        {
            //arrange
            var target = new CalculatorCart();

            //act
            var actual = target.Compute();

            //assert
            var expect = 100;

            Assert.AreEqual(expect, actual);
        }
    }
}
