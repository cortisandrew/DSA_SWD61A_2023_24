using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProject
{
    /// <summary>
    ///  This interface represents the Heap ADT.
    ///  The heap offers these methods
    ///  It is assumed that the heap has the heap-order property with the largest value at the top
    /// </summary>
    public interface IMaxHeap<V>
    {
        /// <summary>
        /// Returns the number of elements stored
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Adds an element with key
        /// Associate a value with each key
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        void Add(int key, V value);


        /// <summary>
        /// Removes the Value associated with the key that has the largest value
        /// </summary>
        V RemoveMax();

        // void IncreasePriority(int key, int newKeyValue);
    }
}
