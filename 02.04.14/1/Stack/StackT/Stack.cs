using System;
using System.Collections.Generic;

namespace StackT
{
    /// <summary>
    /// Stack based on references.
    /// </summary>
    public class Stack<T>
    {
        /// <summary>
        /// Contents of the stack.
        /// </summary>
        private class StackElement
        {
            /// <summary>
            /// Value of stack element.
            /// </summary>
            public T Value { get; set; }

            /// <summary>
            /// Reference on next element.
            /// </summary>
            public StackElement Next { get; set; }
        }

        private StackElement head = null;

        /// <summary>
        /// Push value to a stack.
        /// </summary>
        /// <param name="value">Value to be pushed.</param>
        public void Push(T value)
        {
            var newElement = new StackElement()
            {
                Next = head,
                Value = value
            };

            head = newElement;
        }

        /// <summary>
        /// Returns head value 
        /// </summary>
        public T Pop()
        {
            if (head == null)
            {
                throw new InsufficientExecutionStackException(); 
            }

            var temp = head.Value;
            head = head.Next;
            return temp;
        }

        /// <summary>
        /// Check if stack is empty
        /// </summary>
        /// <returns>True if empty & vc</returns>
        public bool IsEmpty()
        {
            return head == null;
        }

        /// <summary>
        /// Print stack on console
        /// </summary>
        public void PrintStack()
        {
            var temp = head;
            while (temp != null)
            {
                System.Console.Write("{0},", temp.Value);
                temp = temp.Next;
            }
            System.Console.WriteLine();
        }

        /// <summary>
        /// Makes stack empty
        /// </summary>
        public void ClearStack()
        {
            head = null;
        }
    }
}
