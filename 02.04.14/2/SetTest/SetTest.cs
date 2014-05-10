using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Set;

namespace SetTest
{
    [TestClass]
    public class SetTest
    {
        [TestInitialize]
        public void Initialize()
        {
            firstSet = new SetClass<int>();
        }

        [TestMethod]
        public void InsertTest()
        {
            firstSet.InsertElement(1);
            firstSet.InsertElement(2);
            Assert.IsTrue(firstSet.Contains(2));
        }

        [TestMethod]
        public void RemoveTest()
        {
            firstSet.InsertElement(1);
            firstSet.InsertElement(2);
            firstSet.Remove(2);
            Assert.IsFalse(firstSet.Contains(2));
            Assert.IsTrue(firstSet.Contains(1));
        }

        [TestMethod]
        public void IntersectionTest()
        {
            var secondSet = new SetClass<int>();
            firstSet.InsertElement(1);
            firstSet.InsertElement(2);
            secondSet.InsertElement(2);
            secondSet.InsertElement(3);
            //SetClass<int> result = firstSet.Intersection(firstSet, secondSet);
            var result = SetClass<int>.Intersection(firstSet, secondSet);
            Assert.IsTrue(result.Contains(2));
        }

        [TestMethod]
        public void UnionTest()
        {
            var secondSet = new SetClass<int>();
            firstSet.InsertElement(1);
            firstSet.InsertElement(2);
            secondSet.InsertElement(4);
            secondSet.InsertElement(3);
            firstSet.Union(secondSet);
            Assert.IsTrue(firstSet.Contains(3));
        }
        private SetClass<int> firstSet;
    }
}
