using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble
{
    /// <summary>
    /// Class for number's compare.
    /// </summary>
    public class IntCompare : ICompare<int>
    {
        public bool Compare(int elem1, int elem2)
        {
            return elem1 < elem2;
        }
    }
}
