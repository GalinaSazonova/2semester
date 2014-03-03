using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace arrSpiral.Test
{
    using arrSpiral;
    [TestClass]
    public class arrSpiralTest
    {
        [TestMethod]
        public void SpiralWalkTest()
        {
            int[,] arr = new int[3, 3];
            arr[0, 0] = 1;
            arr[0, 1] = 2;
            arr[0, 2] = 3;
            arr[1, 0] = 4;
            arr[1, 1] = 5;
            arr[1, 2] = 6;
            arr[2, 0] = 7;
            arr[2, 1] = 8;
            arr[2, 2] = 9;
            int[] helpArr = new int[9];
            SpiralWalk(arr, 3, ref helpArr);
            Assert.AreEqual(5, helpArr[0]);
            Assert.AreEqual(3, helpArr[8]);
        }
    }
}
