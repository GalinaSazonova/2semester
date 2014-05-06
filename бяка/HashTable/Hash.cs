using System;
using ListT;

namespace HashTable
{
    /// <summary>
    /// Class for Hash Table.
    /// </summary>
    /// <typeparam name="T"></typeparam>
   public class Hash<T>
    {
        /// <summary>
        /// Size of Table.
        /// </summary>
        private const int sizeOfHashTable = 101;
        private List<T>[] buckets = new List<T>[sizeOfHashTable];

        /// <summary>
        /// Create List in each bucket.
        /// </summary>
        /// <param name="hash"></param>
        public Hash(HashFunctionInterface<T> hash)
        {
            for (int i = 0; i < sizeOfHashTable; i++)
            {
                this.buckets[i] = new List<T>();
            }
            this.hash = hash;
        }

        /// <summary>
        /// Add element to hash table.
        /// </summary>
        /// <param name="expression">Element to add</param>
        public void InsertElementToHashTable(T expression)
        {
            this.buckets[this.hash.HashFunction(expression, sizeOfHashTable)].InsertToHead(expression);
        }

        /// <summary>
        /// Removes element from hash table.
        /// </summary>
        /// <param name="expression">Element to remove</param>
        public void RemoveElementFromHashTable(T expression)
        {
            this.buckets[this.hash.HashFunction(expression, sizeOfHashTable)].Remove(this.buckets[this.hash.HashFunction(expression, sizeOfHashTable)].FindPosition(expression));
        }

        /// <summary>
        /// Check if element is in the table.
        /// </summary>
        /// <param name="expression">Element to check</param>
        /// <returns></returns>
        public bool ContainsElement(T expression)
        {
            return this.buckets[this.hash.HashFunction(expression, sizeOfHashTable)].Contains(expression);
        }

        /// <summary>
        /// Print Hash Table.
        /// </summary>
        public void PrintHashTable()
        {
            for (int i = 0; i != sizeOfHashTable; i++)
            {
                this.buckets[i].PrintList();
            }
        }

       /// <summary>
       /// Name of method speaks for itself.
       /// </summary>
       /// <param name="newHashFunction"></param>
       public void ChangingHashFunctionWhileUsingHashTable(HashFunctionInterface<T> newHashFunction)
        {
            hash = newHashFunction;
            for (int i = 0; i < sizeOfHashTable; i++)
            {
                if (buckets[i].SizeOfList() != 0)
                {
                    for (int j = 0; j < buckets[i].SizeOfList(); j++)
                    {
                        var temp = buckets[i].FindValue(j);
                        buckets[i].Remove(j);
                        InsertElementToHashTable(temp);
                    }
                }
            }
        }

        private HashFunctionInterface<T> hash;
    }
}
