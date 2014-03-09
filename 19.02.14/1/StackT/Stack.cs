
namespace StackT
{
    /// <summary>
    /// Stack based on references.
    /// </summary>
    public class Stack
    {
        private class StackElement
        {
            private int aValue;

            public int Value
            {
                get
                {
                    return aValue;
                }

                set
                {
                    this.aValue = value;
                }
            }

            public StackElement Next { get; set; }
        }

        private StackElement head = null;

        /// <summary>
        /// Push value to a stack.
        /// </summary>
        /// <param name="value">Value to be pushed.</param>
        public void Push(int value)
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
        public int Pop()
        {
            if (head == null)
            {
                return -1;
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
        /// Check if value is in the stack
        /// </summary>
        /// <param name="valueToCheck"></param>
        /// <returns>true if valueToCheck in stack</returns>
        public bool Contains(int valueToCheck)
        {
            var temp = head;
            bool contain = false;
            while (temp != null)
            {
                if (temp.Value == valueToCheck)
                {
                    contain = true;
                }
                temp = temp.Next;
            }
            return contain;
        }

        /// <summary>
        /// Count how many elements are already in stack
        /// </summary>
        /// <returns>number of elements</returns>
        public int Count()
        {
            var temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }
            return count;
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
