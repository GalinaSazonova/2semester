using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTree
{
    public class TreeException : Exception
    {
        public TreeException(string mes) : base(mes)
        { }
    }
}
