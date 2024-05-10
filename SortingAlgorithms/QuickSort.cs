using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class QuickSort
    {
        public void Sort(int[] arr)
        {
            //Sort(arr, 0, arr.Length);
            Sort(arr, 0, arr.Length - 1);
        }

        private void Sort(int[] arr, int lo, int hi)
        {
            if (lo >= hi)
            {
                // stopping condition
                // the array to sort is 1 or 0
                return;
            }

            int pivotIndex = SelectPivotIndex(arr, lo, hi);

            // newPivotIndex is where the pivot is placed after partitioning...
            int newPivotIndex = Partition(arr, lo, hi, pivotIndex);

            // recursive calls!
            Sort(arr, lo, newPivotIndex - 1);
            Sort(arr, newPivotIndex + 1, hi);
        }

        /// <summary>
        /// Compare all the elements within the range between lo and hi with the pivot
        /// All small elements go to the left of the pivot
        /// All large elements go to the right of the pivot
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="lo"></param>
        /// <param name="hi"></param>
        /// <param name="pivotIndex">The new index of the pivot after partitioning</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private int Partition(int[] arr, int lo, int hi, int pivotIndex)
        {
            throw new NotImplementedException();
        }

        private int SelectPivotIndex(int[] arr, int lo, int hi)
        {
            return lo; // in your assignment you want a rightmost pivot however...
        }
    }
}
