using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackT;

namespace StackTest
{
    [TestClass]
    public class StackTest
    {
        [TestInitialize]
        public void Initialize()
        {
            stack = new Stack();
        }

        [TestMethod]
        public void PushTest()
        {
            stack.Push(1);
            Assert.IsFalse(stack.IsEmpty());
        }

        [TestMethod]
        public void PopTest()
        {
            stack.Push(1);
            Assert.AreEqual(1, stack.Pop());
        }

        [TestMethod]
        public void TwoElementsPopTest()
        {
            stack.Push(1);
            stack.Push(2);
            Assert.AreEqual(2, stack.Pop());
            Assert.AreEqual(1, stack.Pop());
        }

        [TestMethod]
        public void PopFromEmptyStackTest()
        {
            stack.Pop();
        }

        [TestMethod]
        public void ContainsTest()
        {
            stack.Push(1);
            stack.Push(2);
            stack.Pop();
            stack.Push(9);
            Assert.IsTrue(stack.Contains(9));
        }

        [TestMethod]
        public void CountTest()
        {
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();
            Assert.AreEqual(2, stack.Count());
        }
        
        [TestMethod]
        public void CountEmptyStackTest()
        {
            Assert.AreEqual(0, stack.Count());
        }
        private Stack stack;
    }
}
