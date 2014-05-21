using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble
{
    /// <summary>
    /// Interface for Compare function.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICompare<T>
    {
        /// <summary>
        /// Compare function.
        /// </summary>
        /// <param name="elem1"></param>
        /// <param name="elem2"></param>
        /// <returns></returns>
        bool Compare(T elem1, T elem2);
    }
}
