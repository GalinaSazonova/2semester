using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble
{
    /// <summary>
    /// Class for comparing lines.
    /// </summary>
    public class StringCompare2 : ICompare<string>
    {
        public bool Compare(string elem1, string elem2)
        {
            return elem1.Length * elem2.Length / 2 == 0;
        }
    }
}
