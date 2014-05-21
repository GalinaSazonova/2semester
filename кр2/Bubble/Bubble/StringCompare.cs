using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble
{
    /// <summary>
    /// Class for comparing lenght of lines.
    /// </summary>
    public class StringCompare : ICompare<string>
    {
        public bool Compare(string elem1, string elem2)
        {
            return elem1.Length > elem2.Length;
        }
    }
}
