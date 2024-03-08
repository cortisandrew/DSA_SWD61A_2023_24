using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorImplementations
{
    public class Node<T>
    {
        private T element;

        private Node<T>? next;


        public T Element { 
            get { return element; }
            private set { element = value; }
        }

        // previous is used for doubly linked lists...
        // private Node<T>? previous;

        // Sometimes nodes can store a reference to the linked list that they belong to...
        // Will not be used during our lectures
        // private SinglyLinkedList<T> parent;

        public Node<T>? Next
        {
            get { return next; }
            internal set { next = value; }
        }

        public Node(T element, Node<T>? next)
        {
            this.element = element;
            this.next = next;
        }

        public override string ToString()
        {
            if (element == null)
            {
                return "[ NULL ]";
            }
            else
            {
                return "[ " + element.ToString() + " ]";
            }
        }
    }
}
