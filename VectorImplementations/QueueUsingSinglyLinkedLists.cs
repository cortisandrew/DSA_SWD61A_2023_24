using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorImplementations
{
    public class QueueUsingSinglyLinkedLists<T> : IQueueADT<T>
    {
        private SinglyLinkedList<T> sll = new SinglyLinkedList<T>();

        public int Size => sll.Size;

        public void Enqueue(T element)
        {
            sll.Append(element);
        }

        public T Dequeue()
        {
            return sll.RemoveHead();
        }

        public T Peek()
        {
            return sll.GetFirstElement();
        }

        public override string ToString()
        {
            return sll.ToString();
        }
    }
}
