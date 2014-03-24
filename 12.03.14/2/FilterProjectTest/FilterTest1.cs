using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FilterProject;

namespace FilterProjectTest
{
    [TestClass]
    public class FilterTest1
    {
        [TestMethod]
        public void FilterTest()
        {
            List<int> list = new List<int> { 5, 2, 8, 3, 7 };
            List<int> filterList = FilterClass<int>.Filter(list, x => (x % 2) == 0);
            Assert.IsTrue(filterList[0] == 2 && filterList.Count == 2);
        }
    }
}
