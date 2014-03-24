using System;
using System.Collections.Generic;

namespace Map
{
    /// <summary>
    /// Class for map function
    /// </summary>
    public class MapClass<T>
    {
        /// <summary>
        /// Changes list by input function.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="function"></param>
        /// <returns>New list</returns>
        public static List<T> Map(List<T> list, Func<T, T> function)
        {
            List<T> mapList = new List<T>();
            foreach (var tempor in list)
            {
                mapList.Add(function(tempor));
            }
            return mapList;
        }
    }
}
