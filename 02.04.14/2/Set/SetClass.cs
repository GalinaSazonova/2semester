using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListT;

namespace Set
{
    /// <summary>
    /// Class for sets.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SetClass<T>
    {
        public SetClass()
        {
            elements = new MyList<T>();
        }

        /// <summary>
        /// Check if element in set.
        /// </summary>
        /// <param name="valueToCheck"></param>
        /// <returns></returns>
        public bool Contains(T valueToCheck)
        {
            return elements.Contains(valueToCheck);
        }

        /// <summary>
        /// Inserts element in set, if it isn't in set already.
        /// </summary>
        /// <param name="value"></param>
        public void InsertElement(T value)
        {
            if(!Contains(value))
            {
                elements.InsertElementByPosition(value, elements.SizeOfList());
            }
        }

        /// <summary>
        /// Removes element from set, if element isn't int set exception throws.
        /// </summary>
        /// <param name="value"></param>
        public void Remove(T value)
        {
            elements.Remove(elements.FindPosition(value));
        }

        
        public static SetClass<T> Intersection(SetClass<T> firstSet,SetClass<T> secondSet)
        {
            SetClass<T> resultSet = new SetClass<T>();
            foreach (T element in secondSet.elements)
            {
                if (firstSet.Contains(element))
                {
                    resultSet.InsertElement(element);
                }
            }
            return resultSet;
        }

        public void Intersection(SetClass<T> secondSet)
        {

        }
        /// <summary>
        /// Union of 2 sets, 1 set is result of union.
        /// </summary>
        /// <param name="secondSet"></param>
        public void Union(SetClass<T> secondSet)
        {
            foreach (T element in secondSet.elements)
            {
                InsertElement(element);
            }
        }

        /// <summary>
        /// Check if set is empty.
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return elements.SizeOfList() == 0;
        }

        private MyList<T> elements;
    }
}
