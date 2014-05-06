using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    /// <summary>
    /// Interface for Hash Function.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface HashFunctionInterface<T>
    {
        int HashFunction(T element, int sizeOfHashTable);
    }
}
