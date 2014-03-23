using System;
namespace ListT
{
    /// <summary>
    /// Doubly linked list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ListT<T>
    {
        private class ListElement
        {
            /// <summary>
            /// Value of List element.
            /// </summary>
            public T Value { get; set; }

            /// <summary>
            /// Reference on next element.
            /// </summary>
            public ListElement Next { get; set; }

            /// <summary>
            /// Reference on previous element.
            /// </summary>
            public ListElement Back { get; set; }
            public ListElement(T value)
            {
                Value = value;
            }
        }

        private ListElement head;
        private int size;

        /// <summary>
        /// Insert element into the head of the list
        /// </summary>
        /// <param name="value">Value to insert</param>
        virtual public void InsertToHead(T value)
        {
            ListElement temp = head;
            ListElement newElement = new ListElement(value);
            newElement.Next = temp;
            newElement.Back = null;
            head = newElement;
            if (size != 0)
            {
                temp.Back = head;
            }
            size++;
        }

        /// <summary>
        /// Insert new element into tale of list
        /// </summary>
        /// <param name="value">Value to enter</param>
        virtual public void InsertToTail(T value)
        {
            if (size == 0)
            {
                InsertToHead(value);
                return;
            }
            ListElement taleElement = head;
            for (int i = 1; i < size; i++)
            {
                taleElement = taleElement.Next;
            }
            ListElement newElement = new ListElement(value);
            taleElement.Next = newElement;
            newElement.Back = taleElement;
            newElement.Next = null;
            size++;
        }

        /// <summary>
        /// Insert element by entered position
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position"></param>
        virtual public void InsertElementByPosition(T value, int position)
        {
            if (position < 0 || position > size)
            {
                System.Console.WriteLine("Wrong position");
                return;
            }
            if (position == 0)
            {
                InsertToHead(value);
                return;
            }
            if (position == size)
            {
                InsertToTail(value);
                return;
            }
            ListElement temp = head;
            while (position > 0)
            {
                temp = temp.Next;
                position--;
            }
            ListElement newElement = new ListElement(value);
            newElement.Next = temp;
            newElement.Back = temp.Back;
            temp.Back.Next = newElement;
            temp.Back = newElement;
            size++;
        }

        /// <summary>
        /// Removes element by entered position
        /// </summary>
        /// <param name="position"></param>
        public void Remove(int position)
        {
            if (position < 0 || position > size)
            {
                System.Console.WriteLine("Wrong position");
                return;
            }
            ListElement temp = head;
            for (int i = 0; i < position; i++)
            {
                temp = temp.Next;
            }
            if (temp == head)
            {
                head = temp.Next;
                size--;
                return;
            }
            if (temp.Next == null)
            {
                temp.Back.Next = null;
                size--;
                return;
            }
            temp.Back.Next = temp.Next;
            temp.Next.Back = temp.Back;
            size--;
        }

        /// <summary>
        /// Returns size of list
        /// </summary>
        /// <returns></returns>
        public int SizeOfList()
        {
            return size;
        }

        /// <summary>
        /// Check if value is in the list
        /// </summary>
        /// <param name="valueToCheck"></param>
        /// <returns>true if valueToCheck in list</returns>
        public bool Contains(T valueToCheck)
        {
            var temp = head;
            bool contain = false;
            while (temp != null)
            {
                if (Equals(temp.Value,valueToCheck))
                {
                    contain = true;
                }
                temp = temp.Next;
            }
            return contain;
        }

        /// <summary>
        /// Returns position by entered value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int FindPosition(T value)
        {
            int position = 0;
            var temp = head;
            while (temp != null)
            {
                if (Equals(temp.Value, value))
                {
                    return position;
                }
                position++;
                temp = temp.Next;
            }
            return -1;
        }

        /// <summary>
        /// Returns value by position
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public T FindValue(int position)
        {
            var temp = head;
            for (int i = 0; i < position; i++)
            {
                temp = temp.Next;
            }
            return temp.Value;
        }

        /// <summary>
        /// Makes list empty
        /// </summary>
        public void ClearList()
        {
            head = null;
            size = 0;
        }

        /// <summary>
        /// Wrutes all elements of list in string
        /// </summary>
        /// <returns></returns>
        public string ListToString()
        {
            var temp = head;
            string listInString = Convert.ToString(temp.Value);
            temp = temp.Next;
            while (temp != null)
            {
                listInString += ", " + Convert.ToString(temp.Value);
                temp = temp.Next;
            }
            return listInString;
        }
    }
}
