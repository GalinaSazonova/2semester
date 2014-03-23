using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class BoringStandartHashFunction : HashFunctionInterface<int>
    {
        public int HashFunction(int element, int sizeOfHashTable)
        {
            return (element.GetHashCode() % sizeOfHashTable);
        }
    }
}
