using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProject
{
    public class PriorityQueue<T>
    {
        BinaryMaxHeap<T> heap = new BinaryMaxHeap<T>();

        public void Enqueue(int key, T value)
        {
            heap.Add(key, value);
        }

        public T Dequeue()
        {
            // return the item with highest priority
            return heap.RemoveMax();
        }
    }
}
