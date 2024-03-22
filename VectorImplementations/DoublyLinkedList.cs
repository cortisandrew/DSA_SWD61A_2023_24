using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorImplementations
{
    public class DoublyLinkedList<T>
    {
        public int Size { get; private set; }

        public DoublyLinkedListNode<T>? Head { get; private set; }

        public DoublyLinkedListNode<T>? Tail { get; private set; }


        public void InsertFirst(T element)
        {
            // Step (i) build
            DoublyLinkedListNode<T> newNode =
                new DoublyLinkedListNode<T>(element, null, Head);

            // Step (ii) only required in doubly linked lists
            // Singly linked lists don't have a previous
            // Update the "old" Head of List's previous
            if (Head != null)
            {
                // When the size is at least 1, the Head exists and is not null
                Head.Previous = newNode;
            }

            // Step iii: Optional, update the tail)
            if (Size == 0) // || head == null
            {
                // this is the first node to be added...
                // this means that since the linked list will only have 1 node, it is also the tail
                Tail = newNode;
            }

            // Step (iv): Update the head of list
            Head = newNode;

            // Step (v):
            Size++;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<-> ");
            DoublyLinkedListNode<T>? cursor = Head;
            while (cursor != null)
            {
                sb.Append(cursor.Element);
                sb.Append(" <-> ");
                cursor = cursor.Next;
            }
            sb.AppendLine();

            return sb.ToString();
        }

        public void InsertBefore(T element, DoublyLinkedListNode<T> cursor)
        {
            // Validation
            if (cursor == null)
            {
                throw new ArgumentNullException("You cannot insert before null!");
            }

            // if we want to insert before the head of list,
            // then this is equivalent to InsertFirst
            if (cursor==Head)
            {
                InsertFirst(element);
                return;
            }

            // Step (i): Build
            DoublyLinkedListNode<T> newNode = new DoublyLinkedListNode<T>(
                element,
                cursor.Previous,
                cursor);

            // Step (ii): Update existing links
            // cursor.Previous.Next = newNode;
            DoublyLinkedListNode<T> nodeBeforeCursor = cursor.Previous;
            nodeBeforeCursor.Next = newNode;

            cursor.Previous = newNode;


            // Don't forget
            Size++;



        }
    }
}
