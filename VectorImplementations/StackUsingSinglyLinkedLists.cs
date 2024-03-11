using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorImplementations
{
    public class StackUsingSinglyLinkedLists<T> : IStackADT<T>
    {
        private SinglyLinkedList<T> linkedList = new SinglyLinkedList<T>();

        public int Size
        {
            get
            {
                return linkedList.Size;
            }
        }

        public T Peek()
        {
            return linkedList.GetFirstElement();
        }

        public T Pop()
        {
            return linkedList.RemoveLast();
            //return linkedList.RemoveHead();
        }

        public void Push(T elem)
        {
            linkedList.Append(elem);
            //linkedList.InsertFirst(elem);
        }
    }
}
