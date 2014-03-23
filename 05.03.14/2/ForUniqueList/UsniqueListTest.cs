using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UniqueListT;

namespace ForUniqueList
{
    [TestClass]
    public class UsniqueListTest
    {
        [TestInitialize]
        public void Initialize()
        {
            uniList = new UniqueList<int>();
        }

        [TestMethod]
        [ExpectedException(typeof(ExeptionAlreadyExist))]
        public void InsertToHeadTest()
        {
            uniList.InsertToHead(9);
            uniList.InsertToHead(9);
        }

        [TestMethod]
        [ExpectedException(typeof(ExeptionAlreadyExist))]
        public void InsertToTailTest()
        {
            uniList.InsertToTail(3);
            uniList.InsertToTail(3);
        }

        [TestMethod]
        [ExpectedException(typeof(ExeptionAlreadyExist))]
        public void InsertTest()
        {
            uniList.InsertElementByPosition(4, 0);
            uniList.InsertElementByPosition(4, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ExeptionDeleteWrong))]
        public void RemoveTest()
        {
            uniList.Remove(8);
        }

        private UniqueList<int> uniList;
    }
}
