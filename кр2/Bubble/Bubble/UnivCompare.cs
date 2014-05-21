using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble
{
    /// <summary>
    /// Class for universial comparison.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class UnivCompare<T> : ICompare<T>
    {
        public bool Compare(T elem1, T elem2)
        {
            int hashElem1 = elem1.GetHashCode();
            int hashElem2 = elem2.GetHashCode();
            return hashElem1 > hashElem2;
        }
    }
}
