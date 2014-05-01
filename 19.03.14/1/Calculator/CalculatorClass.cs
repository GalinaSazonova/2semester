using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackCalcul;

namespace Calculator
{
    /// <summary>
    /// Class for calculator.
    /// </summary>
    public class CalculatorClass
    {
        public CalculatorClass()
        {
            stack = new Stack();
        }

        /// <summary>
        /// Cleans stack.
        /// </summary>
        public void Clean()
        {
            this.stack.ClearStack();
        }

        /// <summary>
        /// Adds number to stack, calculate, if there is something.
        /// </summary>
        /// <param name="number"></param>
        public void AddNumber(int number)
        {
            if (this.stack.IsEmpty())
                this.stack.Push(number);
            else
            {
                this.stack.Push(number);
                Calculator();
            }
        }

        /// <summary>
        /// Adds sign, calculates, if there is an expression, changes sign.
        /// </summary>
        /// <param name="sign"></param>
        public void AddSign(char sign)
        {
            if (this.stack.IsEmpty())
                return;
            var inHead = this.stack.Pop();
            if (this.stack.IsEmpty())
            {
                this.stack.Push(inHead);
                this.stack.Push(sign);
            }
            else
            {
                int afterHead = this.stack.Pop();
                if (this.stack.IsEmpty())
                {
                    this.stack.Push(afterHead);
                    this.stack.Push(sign);
                }
                else
                {
                    this.stack.Push(afterHead);
                    this.stack.Push(inHead);
                    Calculator();
                    this.stack.Push(sign);
                }
            }
        }

        /// <summary>
        /// Calculating, if there is right expression.
        /// </summary>
        public void Calculator()
        {
            int secondOperand = 0;
            int firstOperand = 0;
            char operation = '\0';
            int result = 0;
            if (!this.stack.IsEmpty())
            {
                secondOperand = this.stack.Pop();
            }
            else
            {
                return;
            }
            if (!this.stack.IsEmpty())
            {
                operation = (char)this.stack.Pop();
            }
            else
            {
                this.stack.Push(secondOperand);
                return;
            }
            if (!this.stack.IsEmpty())
            {
                firstOperand = this.stack.Pop();
            }
            else
            {
                this.stack.Push(secondOperand);
                return;
            }
            switch (operation)
            {
                case '+':
                    {
                        result = secondOperand + firstOperand;
                        break;
                    }
                case '-':
                    {
                        result = firstOperand - secondOperand;
                        break;
                    }
                case '/':
                    {
                        if (secondOperand != 0)
                        {
                            result = firstOperand / secondOperand;
                            break;
                        }
                        else
                        {
                            throw new DivideByZeroException();
                        }
                    }
                case '*':
                    {
                        result = firstOperand * secondOperand;
                        break;
                    }
            }
            this.stack.Push(result);
        }

        /// <summary>
        /// Returns values from stack.
        /// </summary>
        /// <returns></returns>
        public string Result()
        {
            return this.stack.StackToString();
        }

        /// <summary>
        /// Returns if stack is empty.
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return this.stack.IsEmpty();
        }

        public void PopSign()
        {
            this.stack.Pop();
        }

        private Stack stack;
    }
}
