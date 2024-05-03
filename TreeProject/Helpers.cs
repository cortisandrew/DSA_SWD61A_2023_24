using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProject
{
    public static class Helpers
    {
        /// <summary>
        /// Extension methods
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public static void Swap<T>(this IList<T> list, int i, int j)
        {
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}
