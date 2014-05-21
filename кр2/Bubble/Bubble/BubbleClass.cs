using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble
{
    /// <summary>
    /// Class for bubble sort of any kind of elements.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BubbleClass<T>
    {
        /// <summary>
        /// Sort method.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="size"></param>
        /// <param name="methodOfCompare"></param>
        public void BubbleSort (ref T[] array, int size, ICompare<T> methodOfCompare)
        {
            for (int i = 0; i < size - 1; ++i)
            {
                for (int j = i + 1; j < size; ++j)
                {
                    if (methodOfCompare.Compare(array[i], array[j]))
                    {
                        T temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}
