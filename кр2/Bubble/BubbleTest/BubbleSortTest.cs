using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bubble;

namespace BubbleTest
{
    [TestClass]
    public class BubbleSortTest
    {
        [TestInitialize]
        public void Initialize()
        {
            bubbleSortInt = new BubbleClass<int>();
            univCompareInt = new UnivCompare<int>();
            bubbleSortString = new BubbleClass<string>();
            univCompareStr = new UnivCompare<string>();
            intCompare = new IntCompare();
            stringCompare = new StringCompare();
            stringCompare2 = new StringCompare2();
        }

        [TestMethod]
        public void IntTest()
        {
            int[] array = new int[5] { 3, 6, 7, 1, 2 };
            bubbleSortInt.BubbleSort(ref array, 5, univCompareInt);
            Assert.AreEqual(1, array[0]);
        }

        [TestMethod]
        public void StringTest()
        {
            string[] array = new string[3] { "fd", "asd", "a" };
            bubbleSortString.BubbleSort(ref array, 3, univCompareStr);
            Assert.AreEqual("a", array[1]);
            Assert.IsTrue(univCompareStr.Compare("a", "asd"));
            Assert.AreEqual("fd", array[2]);
        }

        [TestMethod]
        public void IntCompTest()
        {
            int[] array = new int[3] { -1, 5, 0 };
            bubbleSortInt.BubbleSort(ref array, 3, intCompare);
            Assert.AreEqual(5, array[0]);
            Assert.AreEqual(-1, array[2]);
        }

        [TestMethod]
        public void StringCompareTest()
        {
            string[] array = new string[3] { "fd", "asd", "a" };
            bubbleSortString.BubbleSort(ref array, 3, stringCompare);
            Assert.AreEqual("a", array[0]);
        }

        [TestMethod]
        public void AnotherWayOfCompareTest()
        {
            string[] array = new string[3] { "fd", "asd", "a"};
            bubbleSortString.BubbleSort(ref array, 3, stringCompare2);
            Assert.AreEqual("a", array[2]);
            Assert.AreEqual("asd", array[1]);
            Assert.AreEqual("fd", array[0]);
        }

        private BubbleClass<int> bubbleSortInt;
        private UnivCompare<int> univCompareInt;
        private BubbleClass<string> bubbleSortString;
        private UnivCompare<string> univCompareStr;
        private IntCompare intCompare;
        private StringCompare stringCompare;
        private StringCompare2 stringCompare2;
    }
}
