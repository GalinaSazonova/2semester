using System;

namespace StackCalcul
{
    /// <summary>
    /// Stack based on array
    /// </summary>
    public class StackArray : StackInterface
    {
        private int[] stack = new int[101];
        private int size;

        /// <summary>
        /// Push value to a stack.
        /// </summary>
        /// <param name="value">Value to be pushed.</param>
        public void Push(int value)
        {
            if (size + 1> stack.Length)
            {
                Array.Resize(ref stack, stack.Length * 2);
            }
            stack[size] = value;
            size++;
        }

        /// <summary>
        /// Returns head value 
        /// </summary>
        public int Pop()
        {
            if (size != 0)
            {
                var temp = stack[size - 1];
                size--;
                return temp;
            }
            else
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Check if stack is empty
        /// </summary>
        /// <returns>True if empty & vc</returns>
        public bool IsEmpty()
        {
            return size == 0;
        }

        /// <summary>
        /// Print stack on console
        /// </summary>
        public void PrintStack()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write("{0}, ", stack[i]);
            }
        }

        /// <summary>
        /// Makes stack empty
        /// </summary>
        public void ClearStack()
        {
            size = 0;
            Array.Clear(stack, 0, stack.Length);
        }
    }
}
