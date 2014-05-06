using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HashTable;
using NMock2;

namespace HashTest
{
    [TestClass]
    public class HashTableTest
    {
        private int Value = 0;
        //[TestInitialize]
        //public void Initialize()
        //{
            
        //}
        private Mockery mocks;
        [TestMethod]
        public void InsertTest()
        {
            //DynamicMock coolHash = new DynamicMock(typeof(HashFunctionInterface<int>));
            mocks = new Mockery();
            HashFunctionInterface<int> mockHash = mocks.NewMock<HashFunctionInterface<int>>();
           // mockHash.SetupResult("HashFunction", Value.GetHashCode(), typeof(int), typeof(int));
            tableInt = new Hash<int>((HashFunctionInterface<int>)mockHash);
            Expect.Once.On()
            //Value = 12;
            //tableInt.InsertElementToHashTable(12);
            //Assert.IsTrue(tableInt.ContainsElement(12));
        }

        [TestMethod]
        public void RemoveTest()
        {

        }

        [TestMethod]
        public void InsertTestForInt()
        {

        }

        [TestMethod]
        public void ChangeTest()
        {
  
        }
        private Hash<int> tableInt;
  
    }
}
