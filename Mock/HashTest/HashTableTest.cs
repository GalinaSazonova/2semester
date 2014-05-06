using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HashTable;
using NMock2;

namespace HashTest
{
    [TestClass]
    public class HashTableTest
    {
        [TestInitialize]
        public void Initialize()
        {
            mocks = new Mockery();
            mockHash = mocks.NewMock<HashFunctionInterface<int>>();
            tableInt = new Hash<int>((HashFunctionInterface<int>)mockHash);
        }

        private Mockery mocks;
        private Hash<int> tableInt;
        HashFunctionInterface<int> mockHash;

        [TestMethod]
        public void InsertTest()
        {
            Expect.AtLeastOnce.On(mockHash).Method("HashFunction").Will(Return.Value(0));
            tableInt.InsertElementToHashTable(1);
            mocks.VerifyAllExpectationsHaveBeenMet();
        }

        [TestMethod]
        public void RemoveTest()
        {
            Expect.AtLeastOnce.On(mockHash).Method("HashFunction").Will(Return.Value(0));
            tableInt.InsertElementToHashTable(12);
            tableInt.InsertElementToHashTable(23);
            Assert.IsTrue(tableInt.ContainsElement(12));
            tableInt.RemoveElementFromHashTable(12);
            Assert.IsTrue(tableInt.ContainsElement(23));
            Assert.IsFalse(tableInt.ContainsElement(12));
        }

        [TestMethod]
        public void ChangeTest()
        {
            HashFunctionInterface<int> newMockHash = mocks.NewMock<HashFunctionInterface<int>>();
            Expect.AtLeastOnce.On(newMockHash).Method("HashFunction").Will(Return.Value(1));
            Expect.AtLeastOnce.On(mockHash).Method("HashFunction").Will(Return.Value(0));
            tableInt.InsertElementToHashTable(12);
            tableInt.ChangingHashFunctionWhileUsingHashTable(newMockHash);
            Assert.IsTrue(tableInt.ContainsElement(12));
        }
    }
}
