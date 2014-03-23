using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class CoolHashFunctionByMe : HashFunctionInterface<string>
    {
        /// <summary>
        /// Calculate Hash Function.
        /// </summary>
        /// <param name="element">Element to add</param>
        /// <returns></returns>
        public int HashFunction(string element, int sizeOfHashTable)
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
            return (int)(result %= (ulong)sizeOfHashTable);
        }

    }
}
