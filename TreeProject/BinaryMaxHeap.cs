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
    public class BinaryMinHeap<V> : IMaxHeap<V>
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
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
