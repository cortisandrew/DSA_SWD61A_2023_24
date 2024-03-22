using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorImplementations
{
    public class DoublyLinkedListNode<T>
    {
        public T Element { get; private set; }

        public DoublyLinkedListNode<T>? Next { get; internal set; }

        /// <summary>
        /// Doubly Linked List Node is similar to the Node we used for Singly Linked List
        /// But it will also have a pointer to the previous node
        /// </summary>
        public DoublyLinkedListNode<T>? Previous { get; internal set; }

        public DoublyLinkedListNode(T Element, DoublyLinkedListNode<T>? previous = null, DoublyLinkedListNode<T>? next = null)
        {
            this.Element = Element;
            this.Previous = previous;
            this.Next = next;
        }
    }
}
