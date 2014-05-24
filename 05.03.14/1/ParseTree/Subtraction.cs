using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTree
{
    /// <summary>
    /// Class for subtraction.
    /// </summary>
    public class Subtraction : Operator
    {
        public override int Calculate()
        {
            return LeftChild.Calculate() - RightChild.Calculate();
        }

        public override string Print()
        {
            return "-";
        }
    }
}
