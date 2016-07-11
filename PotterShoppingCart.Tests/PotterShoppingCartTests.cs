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

        [TestMethod]
        public void Buy_ep1_and_buy_ep2_and_no_buy_other_should_be_190() 
        { 
            //arrange
            var target = new CalculatorCart();

            //act
            var actual = target.Computetwo();

            //assert
            var expect = 190;

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Buy_ep1_and_buy_ep2_and_buy_ep3_and_no_buy_other_should_be_270()
        {
            //arrange
            var target = new CalculatorCart();

            //act
            var actual = target.Computethree();

            //assert
            var expect = 270;

            Assert.AreEqual(expect, actual);
        }
    }
}
