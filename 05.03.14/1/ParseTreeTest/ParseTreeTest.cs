using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParseTree;

namespace ParseTreeTest
{
    [TestClass]
    public class ParseTreeTest
    {
        [TestInitialize]
        public void Initialize()
        {
            tree = new ParseTreeClass("(-(+ 5 5)(* 7 1))");
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(tree.CalculateAll() == 3);
        }

        [TestMethod]
        [ExpectedException(typeof(System.DivideByZeroException))]
        public void ZeroExeption()
        {
            ParseTreeClass checkTree = new ParseTreeClass("(/ 8 0)");
            checkTree.CalculateAll();
        }

        [TestMethod]
        [ExpectedException(typeof(TreeException))]
        public void EmptyExeption()
        {
            ParseTreeClass checkTree = new ParseTreeClass("");
            checkTree.CalculateAll();
        }

        [TestMethod]
        [ExpectedException(typeof(TreeException))]
        public void WrongSymbolExeption()
        {
            ParseTreeClass checkTree = new ParseTreeClass("(/ 8 k)");
            checkTree.CalculateAll();
        }

        private ParseTreeClass tree;
    }
}
