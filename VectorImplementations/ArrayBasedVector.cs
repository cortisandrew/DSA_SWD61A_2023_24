using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorImplementations
{
    public class ArrayBasedVector<T> : IVectorADT<T>
    {
        #region Fields and Constants
        /// <summary>
        /// The field that stores the number of elements added so far
        /// </summary>
        private int size = 0;

        private const int DEFAULT_LENGTH = 100;
        /// <summary>
        /// The array that will be used to store the elements
        /// The length of the array is not always equal to the size. (This only happens when the array is full!)
        /// </summary>
        T[] V; // Notice that the array can have extra spaces for more elements to be added later on...
        #endregion

        /// <summary>
        /// Constructor for ABV. If you pass the initialArrayLength, it will be used to create the length of the initial array
        /// If you do not, then the DEFAULT_LENGTH will be used instead.
        /// </summary>
        /// <param name="intialArrayLength"></param>
        public ArrayBasedVector(int intialArrayLength = DEFAULT_LENGTH) 
        {
            V = new T[intialArrayLength];
        }

        /// <summary>
        /// size is storing the number of elements
        /// </summary>
        public int Size
        {
            get { return size; }
        }

        // public bool IsEmpty => size == 0;

        public bool IsEmpty
        {
            get { return size == 0; }
        }

        public T ElementAtRank(int rank)
        {
            // This is the validation
            if (rank < 0 || rank >= size)
            {
                // There is no element with the given rank!
                throw new ArgumentOutOfRangeException(
                    nameof(rank),
                    "The rank is outside of admissable range! You can only pass a rank between 0 and size - 1 (both inclusive)");
            }

            return V[rank];
        }

        public void InsertAtRank(int rank, T element)
        {
            // This is the validation
            if (rank < 0 || rank > size)
            {
                // There is no element with the given rank!
                throw new ArgumentOutOfRangeException(
                    nameof(rank),
                    "The rank is outside of admissable range! You can only pass a rank between 0 and size (both inclusive)");
            }

            if (V.Length == size)
            {
                // The array is full!
                // You need to handle this (later)...
                throw new NotImplementedException();
            }

            for (int i = size - 1; i >= rank; i--)
            {
                // shift each element backwards by one position (assuming there are enough places available)
                V[i + 1] = V[i];
            }

            // this creates an available space at rank
            V[rank] = element; // place the new element in the given position
            size++; // you have successfully added a new element. Size increases
        }

        public void Append(T element)
        {
            InsertAtRank(size, element);
        }

        /// <summary>
        /// Replace the element at rank and return the old element that has been replaced
        /// </summary>
        /// <param name="rank"></param>
        /// <param name="element"></param>
        /// <returns></returns>
        public T ReplaceAtRank(int rank, T element)
        {
            ValidateRange(
                rank,
                0,
                size - 1,
                nameof(rank),
                "The rank is outside of admissable range! You can only pass a rank between 0 and size - 1 (both inclusive)");

            T oldElement = V[rank];
            V[rank] = element;
            return oldElement;
        }

        private void ValidateRange(int rank, int minValue, int maxValue, string parameterName, string messageInformation)
        {
            // This is the validation
            if (rank < minValue || rank > maxValue)
            {
                // There is no element with the given rank!
                throw new ArgumentOutOfRangeException(
                    parameterName,
                    messageInformation);
            }
        }

        public T RemoveAtRank(int rank)
        {
            ValidateRange(rank, 0, size - 1, "rank", "The rank is outside of admissable range! You can only pass a rank between 0 and size - 1 (both inclusive)");

            T removedValue = V[rank];

            for (int i = rank; i < size - 1; i++)
            {
                V[i] = V[i + 1];
            }

            V[size - 1] = default;

            size--;
            return removedValue;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            sb.Append(String.Join(", ", V.Take(size)));
            sb.AppendLine("]");

            return sb.ToString();
        }

    }
}
