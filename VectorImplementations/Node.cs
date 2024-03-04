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
