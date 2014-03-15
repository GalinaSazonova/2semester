using System;

namespace StackCalcul
{
    class Program
    {
        /// <summary>
        /// Calculating exression written in postfix
        /// </summary>
        /// <param name="stack"></param>
        /// <param name="line"></param>
        /// <returns></returns>
       static int Calculator(StackInterface stack, string line)
        {
            int mainResult = 0;
            for (int i = 0; i != line.Length; i++)
            {
                char symbol = line[i];
                if (symbol != '-' && symbol != '*' && symbol != '/' && symbol != '+' && symbol != ' ')
                {
                    stack.Push(Convert.ToInt16(symbol) - 48);
                }
                else switch (symbol)
                    {
                        case '+':
                            {
                                int result = 0;
                                result += stack.Pop();
                                result += stack.Pop();
                                stack.Push(result);
                                break;
                            }
                        case '-':
                            {
                                int result = 0;
                                result -= stack.Pop();
                                result += stack.Pop();
                                stack.Push(result);
                                break;
                            }
                        case '*':
                            {
                                int result = 1;
                                result *= stack.Pop();
                                result *= stack.Pop();
                                stack.Push(result);
                                break;
                            }
                        case '/':
                            {
                                int tempor = stack.Pop();
                                if (tempor != 0)
                                {
                                    int result = 0;
                                    result = stack.Pop() / tempor;
                                    stack.Push(result);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Error: fuuu!! there is a zero in division!!!\n");
                                    mainResult = -99999;
                                    break;
                                }
                            }
                        default:
                            {
                                continue;
                            }
                    }
            }
            if (mainResult != -99999)
            {
                mainResult = stack.Pop();
                return mainResult;
            }
            else
            {
                return mainResult;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your expression");
            string line = Console.ReadLine();
            //StackArray stack = new StackArray();
            Stack stack = new Stack();
            Console.WriteLine("Result of calculating: {0}", Calculator(stack, line));
        }
    }
}
