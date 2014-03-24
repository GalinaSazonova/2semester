using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoldProject;
using System.Collections.Generic;

namespace FoldTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4 };
            Assert.IsTrue(FoldClass<int>.Fold(list, 1, (x, y) => x * y) == 24);
        }
    }
}
