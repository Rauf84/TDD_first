using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDFirst;
using System;
using System.Collections.Generic;
using System.Text;

namespace TDDFirst.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        Calculator calc = new Calculator();

        [TestMethod()]
        public void AddTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DivideTest()
        {
            var actual = calc.Divide(10, 0);
            var expected = 0;
            Assert.AreEqual(expected,actual);
        }

        [TestMethod()]
        public void DivideTest2()
        {
            var actual = calc.Divide(9, 2);
            var expected = 4;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DivideTest3()
        {
            var actual = Math.Floor(calc.Divide(9, 2)); // avrundar uppåt
            var expected = 4;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DivideTest_Ceiling()
        {
            var actual = Math.Ceiling(calc.Divide(9, 2));
            var expected = 5;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DivideTest_Round()
        {
            var actual = Math.Round(calc.Divide(9, 2));
            double expected = 4.5;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DivideTest_Truncate()
        {
            var actual = Math.Truncate(calc.Divide(9, 2));
            var expected = 4;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void SubtractTest()
        {
            Assert.Fail();
        }
    }
}