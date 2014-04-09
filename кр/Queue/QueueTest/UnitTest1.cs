using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Queue;

namespace QueueTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Initialize()
        {
            queue = new QueueClass<int>();
        }
    
        [TestMethod]
        public void AddTest()
        {
            queue.Enqueue(5, 7);
            Assert.IsFalse(queue.IsEmpty());
        }

        [TestMethod]
        public void DequeueTest()
        {
            queue.Enqueue(5, 7);
            queue.Enqueue(9, 8);
            Assert.IsFalse(queue.IsEmpty());
            Assert.AreEqual(9, queue.Dequeue());
            Assert.IsFalse(queue.IsEmpty());
            Assert.AreEqual(7, queue.MaxPr());
            Assert.AreEqual(5, queue.Dequeue());
            Assert.AreEqual(0, queue.MaxPr());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void DequeueExTest()
        {
            queue.Dequeue();
        }
        private QueueClass<int> queue;
    }
}
