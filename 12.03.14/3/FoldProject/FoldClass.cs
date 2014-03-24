using System;
using System.Collections.Generic;

namespace FoldProject
{
    /// <summary>
    /// Class for fold function.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class FoldClass<T>
    {
        /// <summary>
        /// Gets list and begin number and returns result of calcuating function for whole list.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="begin"></param>
        /// <param name="function"></param>
        /// <returns></returns>
        public static int Fold(List<T> list, int begin, Func<int, T, int> function)
        {
            foreach (var tempor in list)
            {
                begin = function(begin, tempor);
            }
            return begin;
        }
    }
}
