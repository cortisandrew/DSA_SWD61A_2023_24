using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorImplementations;

namespace TreeProject
{
    /// <summary>
    /// A binary min heap
    /// The binary min heap is a binary tree with the following properties:
    /// i) complete
    /// ii) Heap-order (with minimum at the top)
    /// </summary>
    public class BinaryMaxHeap<V> : IMaxHeap<V>
    {
        internal int LeftChildIndex(int parentIndex)
        {
            return 2 * parentIndex + 1;
        }

        internal int RightChildIndex(int parentIndex)
        {
            // return LeftChildIndex(parentIndex) + 1;

            return 2 * parentIndex + 2;
        }

        internal int ParentIndex(int childIndex)
        {
            return (int)Math.Ceiling((childIndex - 2) / 2.0);
        }

        // Make sure to add the reference to the other project if you want to use this!!
        // private ArrayBasedVector<IntegerValuePair<V>> arrayBasedVector = new ArrayBasedVector<IntegerValuePair<V>>();
        private List<IntegerValuePair<V>> list = new List<IntegerValuePair<V>>();

        public int Count
        {
            get { return list.Count; }
        }

        public void Add(int key, V value)
        {
            // Add the new item to the list. The heap is complete but does not have the heap order
            list.Add(new IntegerValuePair<V> { Key = key, Value = value });

            // heap order may be lost at the last position (Count - 1)
            UpHeap(list.Count - 1);
        }

        private void UpHeap(int index)
        {
            // stopping condition: if the element is at the top (index == 0), then there is no more swapping required
            if (index == 0)
            {
                // this is the root
                return;
            }

            int parentIndex = ParentIndex(index);

            if (list[parentIndex].Key < list[index].Key)
            {
                // we still have to fix heap-order
                // in max-heap, larger goes on top!
                list.Swap(index, parentIndex);
                UpHeap(parentIndex);
                return; // we are done!
            }

            // heap-order is restored
            return;
        }

        public V RemoveMax()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("You cannot remove from an empry heap!");
            }

            V returnValue = list[0].Value;

            // copy the last element to position 0
            list.Swap(0, list.Count - 1);
            // list[0] = list[Count - 1]; // alternative method...

            // remove the element that we want to return
            list.RemoveAt(list.Count - 1); // RemoveElementAtRank

            // perfom downheap (or BubbleDown) starting from the root (the place where I no longer have heap-order)
            Downheap(0);

            return returnValue;
        }

        private void Downheap(int index)
        {
            // Compare the value at index with the value at its children
            // If any of the children are larger, swap the index with the LARGEST child (for Max Heap)

            // Keep going until, we do not need to swap OR there are no children

            int leftChildIndex = LeftChildIndex(index); // find the largest child
            int largestChildIndex = int.MinValue;

            if (leftChildIndex >= list.Count)
            {
                // leftChildIndex is outside of bounds
                // this means that there is no left child (and therefore no right child)
                // this means that index is a leaf node (no children to compare with)

                // stopping condition! There are no children
                return;
            } else if (leftChildIndex == list.Count - 1)
            {
                // list.Count - 1 is the very last element
                // since the heap is complete (i.e. filled left to right)
                // the left is the last element, and therefore no right child!
                largestChildIndex = leftChildIndex;
            } else
            {
                // the index has BOTH children!
                // find the largest child

                int rightChildIndex = RightChildIndex(index);
                if (list[leftChildIndex].Key > list[rightChildIndex].Key)
                {
                    largestChildIndex = leftChildIndex;
                } else
                {
                    largestChildIndex = rightChildIndex;
                }
                // we found the index of the largest child!
            }

            if (list[index].Key < list[largestChildIndex].Key)
            {
                // the key is smaller than one of it's children
                // Swap and continue Downheap
                list.Swap(index, largestChildIndex);
                Downheap(largestChildIndex);
            }

            // nothind else to do!
            return;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Graph {");

            if (list.Count > 0)
            {
                sb.AppendLine(list[0].Key.ToString() + ";");
            }

            for (int i = 1; i < list.Count; i++)
            {
                sb.AppendLine(list[ParentIndex(i)].Key + "--" + list[i].Key + ";");
            }

            sb.AppendLine("}");

            return sb.ToString();
        }

        public static List<int> HeapSortDescending(List<int> valuesToSort)
        {
            List<int> sortedResults = new List<int>(valuesToSort.Count);

            BinaryMaxHeap<int> tempHeap = new BinaryMaxHeap<int>();

            // repeat n times
            for (int i = 0; i < valuesToSort.Count; i++)
            {
                // Add takes log(n) time (average)
                tempHeap.Add(valuesToSort[i], valuesToSort[i]);
            }

            // repeat n times
            while (tempHeap.Count > 0)
            {
                // RemoveMax takes log(n) time (average)
                // assumed that append in an ArrayBasedVector takes O(1)
                sortedResults.Add(tempHeap.RemoveMax());
            }

            // total time is n x log(n)
            return sortedResults;
        }
    }
}
