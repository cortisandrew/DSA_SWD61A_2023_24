using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorImplementations
{
    /// <summary>
    /// Represents an ordered sequence of elements of type T
    /// </summary>
    /// <typeparam name="T">The type of elements being stored. The methods will use type T as a parameter or return type (where applicable)</typeparam>
    public interface IVectorADT<T>
    {
        /// <summary>
        /// Returns the number of elements stored within the VectorADT
        /// </summary>
        int Size { get; }

        bool IsEmpty { get; }

        /// <summary>
        /// Return the element found at the rank passed as a parameter
        /// </summary>
        /// <param name="rank">The rank of the element to return</param>
        /// <returns>The element found at the rank provided in the parameter</returns>
        T ElementAtRank(int rank);

        void InsertAtRank(int rank, T element);
        
        /// <summary>
        /// Replace the element at the rank passed as a parameter and return the old element
        /// </summary>
        /// <param name="rank">The rank of the element to be replaced</param>
        /// <param name="element">The new element to replace the old element</param>
        /// <returns>The old element that has been replaced</returns>
        T ReplaceAtRank(int rank, T element);

        T RemoveAtRank(int rank);

    }
}
