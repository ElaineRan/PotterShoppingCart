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
            var set = 1;
            var count = 1;
            var num = 0;

            //act
            //var actual = target.ComputeOne();
            var actual = target.Compute(set, count, num);

            //assert
            var expect = 100;

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Buy_ep1_and_buy_ep2_and_no_buy_other_should_be_190() 
        { 
            //arrange
            var target = new CalculatorCart();
            var set = 2;
            var count = 1;
            var num = 0;

            //act
            //var actual = target.ComputeTwo();
            var actual = target.Compute(set, count, num);

            //assert
            var expect = 190;

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Buy_ep1_and_buy_ep2_and_buy_ep3_and_no_buy_other_should_be_270()
        {
            //arrange
            var target = new CalculatorCart();
            var set = 3;
            var count = 1;
            var num = 0;

            //act
            //var actual = target.ComputeThree();
            var actual = target.Compute(set, count, num);

            //assert
            var expect = 270;

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Buy_ep1_and_buy_ep2_and_buy_ep3_and_buy_ep4_and_no_buy_other_should_be_320()
        {
            //arrange
            var target = new CalculatorCart();
            var set = 4;
            var count = 1;
            var num = 0;

            //act
            //var actual = target.ComputeFour();
            var actual = target.Compute(set, count, num);

            //assert
            var expect = 320;

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Buy_ep1_and_buy_ep2_and_buy_ep3_and_buy_ep4_and_buy_ep5_should_be_375()
        {
            //arrange
            var target = new CalculatorCart();
            var set = 5;
            var count = 1;
            var num = 0;

            //act
            //var actual = target.ComputeFive();
            var actual = target.Compute(set, count, num);

            //assert
            var expect = 375;

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Buy_ep1_and_buy_ep2_and_buy_ep3_2_should_be_370()
        {
            //arrange
            var target = new CalculatorCart();
            var set = 3;
            var count = 1;
            var num = 1;

            //act
            //var actual = target.ComputeSpecial();
            var actual = target.Compute(set, count, num);

            //assert
            var expect = 370;

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Buy_ep1_and_buy_ep2_2_and_buy_ep3_2_should_be_460()
        {
            //arrange
            var target = new CalculatorCart();
            var set = 3;
            var count = 1;
            var num = 0;

            //act
            //var actual = target.ComputeSpecialSet();
            var actual = target.Compute(set, count, num);

            set = 2;
            count = 1;
            num = 0;

            actual += target.Compute(set, count, num);
            //assert
            var expect = 460;

            Assert.AreEqual(expect, actual);
        }
    }
}
