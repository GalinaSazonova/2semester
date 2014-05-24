using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTree
{
    /// <summary>
    /// Class for operands.
    /// </summary>
    public class Operand : ParseTreeNode
    {
        public Operand(string expr)
        {
            this.Value = expr;
        }

        public string Value { get; set; }

        public override int Calculate()
        {
            return Convert.ToInt32(Value);
        }

        public override string ToPrint()
        {
            return this.Value;
        }
    }
}
