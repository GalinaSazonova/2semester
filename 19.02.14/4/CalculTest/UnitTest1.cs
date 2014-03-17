using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackCalcul;

namespace CalculTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Initial()
        {
            stackR = new StackArray();
            stackRef = new Stack();
        }

        [TestMethod]
        public void PushTest()
        {
            stackR.Push(7);
            Assert.IsFalse(stackR.IsEmpty());
        }

        [TestMethod]
        public void PopTest()
        {
            stackR.Push(1);
            Assert.AreEqual(1, stackR.Pop());
        }

        [TestMethod]
        public void TwoElementsPopTest()
        {
            stackR.Push(1);
            stackR.Push(2);
            Assert.AreEqual(2, stackR.Pop());
            Assert.AreEqual(1, stackR.Pop());
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void PopFromEmptyStackTest()
        {
            stackR.Pop();    
        }

        [TestMethod]
        [ExpectedException(typeof(System.DivideByZeroException))]
        public void CheckZeroArr()
        {
            string line = "20/";
            Program.Calculator(stackR, line);
        }

        [TestMethod]
        [ExpectedException(typeof(System.DivideByZeroException))]
        public void CheckZeroRef()
        {
            string line = "20/";
            Program.Calculator(stackRef, line);
        }

        [TestMethod]
        public void CheckCountArr()
        {
            string line = "78+2*";
            Assert.AreEqual(30, Program.Calculator(stackR, line));
        }

        [TestMethod]
        public void CheckCountRef()
        {
            string line = "78+2*";
            Assert.AreEqual(30, Program.Calculator(stackRef, line));
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void WrongLineArr()
        {
            string line = "7+2";
            Program.Calculator(stackR, line);
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void WrongLineRef()
        {
            string line = "7+2";
            Program.Calculator(stackRef, line);
        }
        private StackArray stackR;
        private Stack stackRef;
    }
}
