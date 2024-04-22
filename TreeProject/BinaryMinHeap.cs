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
    public class BinaryMinHeap<V> : IHeap<V>
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

        public int Count => throw new NotImplementedException();

        public void Add(int key, V value)
        {
            throw new NotImplementedException();
        }

        public V RemoveMin()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
