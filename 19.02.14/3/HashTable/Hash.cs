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
        public Hash()
        {
            for (int i = 0; i < sizeOfHashTable; i++)
            {
                this.buckets[i] = new List<T>();
            }
        }

        /// <summary>
        /// Calculate Hash Function.
        /// </summary>
        /// <param name="element">Element to add</param>
        /// <returns></returns>
        public int HashFunction(T element)
        {
            ulong result = 0;
            int check = 0;
            string temp = element.ToString();
            for (int i = 0; i != temp.Length; i++)
            {
                check++;
                result += temp[i];
                if (check == 4)
                {
                    result *= 73837;
                    check = 0;
                }
            }
            return (int)(result %= sizeOfHashTable);
        }

        /// <summary>
        /// Add element to hash table.
        /// </summary>
        /// <param name="expression">Element to add</param>
        public void InsertElementToHashTable(T expression)
        {
            this.buckets[HashFunction(expression)].InsertToHead(expression);
        }

        /// <summary>
        /// Removes element from hash table.
        /// </summary>
        /// <param name="expression">Element to remove</param>
        public void RemoveElementFromHashTable(T expression)
        {
            this.buckets[HashFunction(expression)].Remove(this.buckets[HashFunction(expression)].FindPosition(expression));
        }

        /// <summary>
        /// Check if element is in the table.
        /// </summary>
        /// <param name="expression">Element to check</param>
        /// <returns></returns>
        public bool ContainsElement(T expression)
        {
            return this.buckets[HashFunction(expression)].Contains(expression);
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
    }
}
