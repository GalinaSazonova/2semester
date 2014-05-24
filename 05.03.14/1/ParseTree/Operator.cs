using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTree
{
    public abstract class  Operator : ParseTreeNode
    {
        public ParseTreeNode LeftChild { get; set; }

        public ParseTreeNode RightChild { get; set; }

        public override string ToPrint()
        {
            return "(" + Print() + " " + this.LeftChild.ToPrint() + " " + this.RightChild.ToPrint() + ")";
        }

        public abstract string Print();

        public override int Calculate()
        {
            throw new NotImplementedException();
        }
    }
}
