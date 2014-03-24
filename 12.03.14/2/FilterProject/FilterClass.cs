using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterProject
{
    /// <summary>
    /// Class for filter function
    /// </summary>
    /// <typeparam name="T"></typeparam>
     public class FilterClass<T>
    {
         /// <summary>
         /// Gets function and filters list as it says
         /// </summary>
         /// <param name="list"></param>
         /// <param name="function"></param>
         /// <returns></returns>
        public static List<T> Filter(List<T> list, Func<T, bool> function)
        {
            List<T> filterList = new List<T>();
            foreach (var tempor in list)
            {
                if (function(tempor))
                {
                    filterList.Add(tempor);
                }
            }
            return filterList;
        }
    }
}
