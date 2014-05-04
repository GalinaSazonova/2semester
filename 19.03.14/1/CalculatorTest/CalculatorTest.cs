using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestInitialize]
        public void Initialize()
        {
            calculator = new CalculatorClass();
        }
        [TestMethod]
        public void AddNumberTest()
        {
            calculator.AddNumber(10);
            Assert.AreEqual(10, Convert.ToInt32(calculator.Result()));
        }

        [TestMethod]
        public void AddSignTest()
        {
            calculator.AddNumber(55);
            calculator.AddSign('+');
            calculator.AddNumber(55);
            calculator.Calculate();
            Assert.AreEqual(110, Convert.ToInt32(calculator.Result()));
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void ZeroExeptionTest()
        {
            calculator.AddNumber(90);
            calculator.AddSign('/');
            calculator.AddNumber(0);
        }
        private CalculatorClass calculator;
    }
}
