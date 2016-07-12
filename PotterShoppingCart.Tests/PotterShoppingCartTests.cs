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
            var actual = target.ComputeOne();

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
            var actual = target.ComputeTwo();

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
            var actual = target.ComputeThree();

            //assert
            var expect = 270;

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Buy_ep1_and_buy_ep2_and_buy_ep3_and_buy_ep4_and_no_buy_other_should_be_320()
        {
            //arrange
            var target = new CalculatorCart();

            //act
            var actual = target.ComputeFour();

            //assert
            var expect = 320;

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Buy_ep1_and_buy_ep2_and_buy_ep3_and_buy_ep4_and_buy_ep5_should_be_375()
        {
            //arrange
            var target = new CalculatorCart();

            //act
            var actual = target.ComputeFive();

            //assert
            var expect = 375;

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Buy_ep1_and_buy_ep2_and_buy_ep3_2_should_be_370()
        {
            //arrange
            var target = new CalculatorCart();

            //act
            var actual = target.ComputeSpecial();

            //assert
            var expect = 370;

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Buy_ep1_and_buy_ep2_2_and_buy_ep3_2_should_be_460()
        {
            //arrange
            var target = new CalculatorCart();

            //act
            var actual = target.ComputeSpecialSet();

            //assert
            var expect = 460;

            Assert.AreEqual(expect, actual);
        }
    }
}
