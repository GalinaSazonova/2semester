using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    /// <summary>
    /// queue on references
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class QueueClass<T>
    {
        private class QueueElement
        {
            /// <summary>
            /// Value of Queue element.
            /// </summary>
            public T Value { get; set; }

            public int Priority { get; set; }

            /// <summary>
            /// Reference on next element.
            /// </summary>
            public QueueElement Next { get; set; }
            /// <summary>
            /// Reference on prev element.
            /// </summary>
            public QueueElement Back { get; set; }

            public QueueElement(T value, int priority)
            {
                Value = value;
                Priority = priority;
            }
        }

            private QueueElement head;
            private int size;
            private int max;

            /// <summary>
            /// add element with priority
            /// </summary>
            /// <param name="value"></param>
            /// <param name="prior"></param>
            public void Enqueue(T value, int prior)
            {
                QueueElement temp = head;
                QueueElement newElement = new QueueElement(value, prior);
                newElement.Next = temp;
                newElement.Back = null;
                head = newElement;
                if (size != 0)
                {
                    temp.Back = head;
                }
                size++;
                if (newElement.Priority > max)
                {
                    max = newElement.Priority;
                }
            }

            /// <summary>
            /// check if queue is empty
            /// </summary>
            /// <returns></returns>
            public bool IsEmpty()
            {
                return (size == 0);
            }

            /// <summary>
            /// count new max priority.
            /// </summary>
            private void NewMax()
            {
                if (!IsEmpty())
                {
                    var temp = head;
                    max = head.Priority;
                    while (temp.Next != null)
                    {
                        if (temp.Priority > max)
                        {
                            max = temp.Priority;
                        }
                        temp = temp.Next;
                    }  
                }
                else
                {
                    max = 0;
                }
            }

            /// <summary>
            /// Returns element with biggest priority, which was first added
            /// </summary>
            /// <returns></returns>
            public T Dequeue()
            {
                if (IsEmpty())
                {
                    throw new Exception();
                }
                else
                {
                    var temp = head;
                    var toReturn = head;
                    while (temp.Next != null)
                    {
                        if (temp.Priority == max)
                        {
                            toReturn = temp;
                        }
                        temp = temp.Next;
                    }

                    var check = toReturn.Value;

                    if (toReturn == head)
                    {
                        head = toReturn.Next;
                        size--;
                        NewMax();
                        return check;
                    }
                    if (toReturn.Next == null)
                    {
                        temp.Back.Next = null;
                        size--;
                        NewMax();
                        return check;
                    }
                    toReturn.Back.Next = toReturn.Next;
                    toReturn.Next.Back = toReturn.Back;
                    size--;
                    NewMax();
                    return check;
                }
            }

        /// <summary>
        /// returns current max priority
        /// </summary>
        /// <returns></returns>
        public int MaxPr()
            {
                return max;
            }
        }
    }
