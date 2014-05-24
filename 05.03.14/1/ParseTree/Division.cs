using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTree
{
    /// <summary>
    /// Class for division.
    /// </summary>
    public class Division : Operator
    {
        public override int Calculate()
        {
            if (RightChild.Calculate() == 0)
            {
                throw new DivideByZeroException();
            }
            return LeftChild.Calculate() / RightChild.Calculate();
        }

        public override string Print()
        {
            return "/";
        }
    }
}
