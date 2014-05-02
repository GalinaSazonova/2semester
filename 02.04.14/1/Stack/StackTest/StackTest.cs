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
            stack = new Stack<int>();
            stackStr = new Stack<string>();
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
        [ExpectedException(typeof(InsufficientExecutionStackException))]
        public void PopFromEmptyStackTest()
        {
            stack.Pop();
        }

        [TestMethod]
        public void PushStrTest()
        {
            stackStr.Push("try");
            Assert.IsFalse(stackStr.IsEmpty());
        }

        [TestMethod]
        public void PopStrTest()
        {
            stackStr.Push("yey");
            stackStr.Push("check");
            Assert.AreEqual("check", stackStr.Pop());
            Assert.AreEqual("yey", stackStr.Pop());
            Assert.IsTrue(stackStr.IsEmpty());
        }
        private Stack<int> stack;
        private Stack<string> stackStr;
    }
}
