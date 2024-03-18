using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorImplementations
{
    public class DoublyLinkedListNode<T>
    {
        public T Element { get; internal set; }
        public DoublyLinkedListNode<T>? Prev { get; internal set; }

        public DoublyLinkedListNode<T>? Next { get; internal set; }

        public DoublyLinkedListNode(T element, DoublyLinkedListNode<T>? prev = null, DoublyLinkedListNode<T>? next = null)
        {
            Element = element;
            Prev = prev;
            Next = next;
        }
    }
}
