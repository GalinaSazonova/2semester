﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListT;

namespace ListTest
{
    [TestClass]
    public class ListTest
    {
        [TestInitialize]
        public void Initialize()
        {
            list = new List<int>();
        }


        [TestMethod]
        public void InsertToHeadTest()
        {
            list.InsertToHead(10);
            Assert.AreEqual(0, list.FindPosition(10));
        }

        [TestMethod]
        public void InsertToTaleTest()
        {
            list.InsertToHead(12);
            list.InsertToTail(4);
            Assert.AreEqual(1, list.FindPosition(4));
        }

        [TestMethod]
        public void InsertElementByPosTest()
        {
            list.InsertToHead(12);
            list.InsertToTail(4);
            list.InsertElementByPosition(5, 1);
            Assert.AreEqual(5, list.FindValue(1));
        }

        [TestMethod]
        public void RemoveTest()
        {
            list.InsertToHead(12);
            list.InsertToTail(4);
            list.InsertElementByPosition(5, 1);
            list.Remove(1);
            Assert.AreEqual(2, list.SizeOfList());
            Assert.AreEqual(1, list.FindPosition(4));
            Assert.IsFalse(list.Contains(5));
        }

        [TestMethod]
        public void ClearTest()
        {
            list.InsertToHead(12);
            list.InsertToTail(4);
            list.InsertElementByPosition(5, 1);
            Assert.AreEqual(3, list.SizeOfList());
            list.ClearList();
            Assert.AreEqual(0, list.SizeOfList());
        }

        [TestMethod]
        public void InsertElementByWrongPositionTest()
        {
            list.InsertToHead(7);
            list.InsertToHead(3);
            list.InsertElementByPosition(5, 3);
            Assert.IsFalse(list.Contains(5));
        }

        [TestMethod]
        public void RemoveByWrongPosition()
        {
            list.InsertToHead(7);
            list.InsertToHead(3);
            list.InsertElementByPosition(5, 1);
            list.Remove(4);
            Assert.AreEqual(3, list.SizeOfList());
        }

        [TestMethod]
        public void ForeachTest()
        {
            list.InsertToHead(12);
            list.InsertToTail(4);
            Assert.AreEqual("124", list.ListToString());
        }

        private List<int> list;
    }
}
