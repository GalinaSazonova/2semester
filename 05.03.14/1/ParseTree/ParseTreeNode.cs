using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTree
{
    /// <summary>
    /// Class for parse tree's nodes.
    /// </summary>
    public abstract class ParseTreeNode
    {
        public abstract int Calculate();

        public abstract string ToPrint();
    }
}
