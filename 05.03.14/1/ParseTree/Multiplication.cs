using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTree
{
    /// <summary>
    /// Class for multiplication.
    /// </summary>
    public  class Multiplication : Operator
    {
        public override int Calculate()
        {
            return LeftChild.Calculate() * RightChild.Calculate();
        }

        public override string Print()
        {
            return "*";
        }
    }
}
