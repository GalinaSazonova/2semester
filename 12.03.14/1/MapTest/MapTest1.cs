using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Map;
using System.Collections.Generic;

namespace MapTest
{
    [TestClass]
    public class MapTest1
    {
        [TestMethod]
        public void MapTest2()
        {
            List<int> list = new List<int> { 1, 2, 3 };
            List<int> mapList = MapClass<int>.Map(list, x => x * x);
            Assert.IsTrue(mapList[0] == 1 && mapList[1] == 4 && mapList[2] == 9);
        }

        [TestMethod]
        public void MapTest3()
        {
            List<int> list = new List<int> { 5 };
            List<int> mapList = MapClass<int>.Map(list, x => x + x);
            Assert.IsTrue(mapList[0] == 10);
        }
    }
}
