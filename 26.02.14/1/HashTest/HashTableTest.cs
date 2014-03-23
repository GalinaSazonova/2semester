using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HashTable;

namespace HashTest
{
    [TestClass]
    public class HashTableTest
    {
        [TestInitialize]
        public void Initialize()
        {
            CoolHashFunctionByMe coolHash = new CoolHashFunctionByMe();
            tableString = new Hash<string>(coolHash);
            BoringStandartHashFunction boringHash = new BoringStandartHashFunction();
            tableInt = new Hash<int>(boringHash);
        }

        [TestMethod]
        public void InsertTest()
        {
            tableString.InsertElementToHashTable("Check");
            Assert.IsTrue(tableString.ContainsElement("Check"));
        }

        [TestMethod]
        public void RemoveTest()
        {
            tableString.InsertElementToHashTable("ololo");
            tableString.InsertElementToHashTable("bravo");
            Assert.IsTrue(tableString.ContainsElement("ololo"));
            tableString.RemoveElementFromHashTable("ololo");
            Assert.IsTrue(tableString.ContainsElement("bravo"));
            Assert.IsFalse(tableString.ContainsElement("ololo"));
        }

        [TestMethod]
        public void InsertTestForInt()
        {
            tableInt.InsertElementToHashTable(12);
            Assert.IsTrue(tableInt.ContainsElement(12));
        }

        [TestMethod]
        public void ChangeTest()
        {
            HashFunctionToCheck toCheck = new HashFunctionToCheck();
            tableInt.InsertElementToHashTable(8);
            tableInt.ChangingHashFunctionWhileUsingHashTable(toCheck);
            Assert.IsTrue(tableInt.ContainsElement(8));
        }

        private Hash<string> tableString;
        private Hash<int> tableInt;
    }
}
