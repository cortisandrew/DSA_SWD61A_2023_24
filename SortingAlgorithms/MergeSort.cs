using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public static class MergeSortClass
    {
        /// <summary>
        /// Carry out a recusrive algorithm called MergeSort
        /// On an array a, which is of length n
        /// 
        /// Merge Sort is NOT carried out in place
        /// T(n) = 2xT(n/2) + Theta(n)
        /// a = 2, is the number of recursive calls
        /// b = 2, is the ratio of the problem size in the recursive
        /// c = 1, is the highest power of n (n^1 = n)
        /// 
        /// log_b(a) = 1
        /// c = 1
        /// T(n) is Theta(n log n) from Master Theorem
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int[] MergeSort(int[] a)
        {
            // Base Case or stopping condition
            if (a.Length <= 1)
            {
                int[] output = new int[a.Length];
                a.CopyTo(output, 0);
                return output;
            }

            // Recursive calls
            // Split the large array a into two (almost) equal parts
            int firstPartLength = a.Length / 2;
            int secondPartLength = a.Length - firstPartLength;

            int[] aPart1 = a.Take(firstPartLength).ToArray();
            int[] aPart2 = a.Skip(firstPartLength).Take(secondPartLength).ToArray();

            // The marge sort is called recursively with an array of length n/2, twice
            // we get the results sorted
            int[] aPart1Sorted = MergeSort(aPart1); // T(n/2)
            int[] aPart2Sorted = MergeSort(aPart2); // T(n/2)

            // Additional work
            return Merge(aPart1Sorted, aPart2Sorted); // Theta(n)
        }

        /// <summary>
        /// Time required to complete is n (aPart1Sorted.Length + aPart2Sorted.Length = n)
        /// </summary>
        /// <param name="aPart1Sorted"></param>
        /// <param name="aPart2Sorted"></param>
        /// <returns></returns>
        private static int[] Merge(int[] aPart1Sorted, int[] aPart2Sorted)
        {
            int[] output = new int[aPart1Sorted.Length + aPart2Sorted.Length];

            int i = 0;
            int j = 0;
            int k = 0;

            // aPart1Sorted.Length + aPart2Sorted.Length = n

            while (i < aPart1Sorted.Length && j < aPart2Sorted.Length)
            {
                if (aPart1Sorted[i] <= aPart2Sorted[j])
                {
                    output[k] = aPart1Sorted[i];
                    i++;
                }
                else
                {
                    output[k] = aPart2Sorted[j];
                    j++;
                }

                k++;
            }

            for (; i < aPart1Sorted.Length; i++)
            {
                output[k] = aPart1Sorted[i];
                k++;
            }

            for (; j < aPart1Sorted.Length; j++)
            {
                output[k] = aPart1Sorted[j];
                k++;
            }

            return output;
        }
    }
}
