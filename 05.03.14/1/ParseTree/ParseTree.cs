using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTree
{
    public class ParseTreeClass
    {
        public ParseTreeClass(string expression)
        {
            position = -1;
            tree = CreateArithmTree(expression);
        }
        
        private int position;

        private ParseTreeNode tree;

        private Operator OperatorNode (string expression)
        {
            switch (expression[0])
            {
                case '/': return new Division();
                case '*': return new Multiplication();
                case '+': return new Addition();
                case '-': return new Subtraction();
            }
            throw new TreeException("Wrong symbol");
        }

        private Operand OperandNode(string expression)
        {
            return new Operand(expression);
        }

        private ParseTreeNode CreateArithmTree(string expression)
        {
            while (expression.Length - 1 > position)
            {
                position++;
                while (expression[position] == ' ')
                {
                    position++;
                }
                string sign = Convert.ToString(expression[position]);
                if (sign[0] == '(')
                {
                    position++;
                    while (expression[position] == ' ')
                    {
                        position++;
                    }
                    sign = Convert.ToString(expression[position]);
                    if (sign[0] != '*' && sign[0] != '/' && sign[0] != '-' && sign[0] != '+')
                    {
                        throw new TreeException("Wrong Token");
                    }
                    var newNode = OperatorNode(sign);
                    newNode.LeftChild = CreateArithmTree(expression);
                    newNode.RightChild = CreateArithmTree(expression);
                    return newNode;
                }
                if (sign[0] >= '0' && sign[0] <= '9')
                {
                    position++;
                    while (expression[position] >= '0' && expression[position] <= '9')
                    {
                        sign += expression[position];
                        position++;
                    }
                    var newNode = OperandNode(sign);
                    return newNode;
                }
                throw new TreeException("Wrong Symbol");
            }
            throw new TreeException("Empty expression");
        }
        
        public int CalculateAll()
        {
            return tree.Calculate();
        }

        public string ToPrintTree()
        {
            return tree.ToPrint(); 
        }
    }
}
