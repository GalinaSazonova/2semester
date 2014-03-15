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
           table = new Hash<string>();
        }

        [TestMethod]
        public void InsertTest()
        {
            table.InsertElementToHashTable("Check");
            Assert.IsTrue(table.ContainsElement("Check"));
        }

        [TestMethod]
        public void RemoveTest()
        {
            table.InsertElementToHashTable("ololo");
            table.InsertElementToHashTable("bravo");
            Assert.IsTrue(table.ContainsElement("ololo"));
            table.RemoveElementFromHashTable("ololo");
            Assert.IsTrue(table.ContainsElement("bravo"));
            Assert.IsFalse(table.ContainsElement("ololo"));
        }
        private Hash<string> table;
    }
}
