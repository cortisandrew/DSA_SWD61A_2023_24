using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorImplementations
{
    public class DoublyLinkedList<T>
    {
        public DoublyLinkedList() { }

        public DoublyLinkedListNode<T>? Head { get; private set; }
        public DoublyLinkedListNode<T>? Tail { get; private set; }

        public int Count { get; private set; } = 0;

        public void InsertFirst(T element)
        {
            // Step (i) - Build Step
            DoublyLinkedListNode<T> newNode = new DoublyLinkedListNode<T>(element, null, Head);

            // Step (ii) - Update the Prev of old head
            if (Head != null) // only do so, if the Head exists
            {
                Head.Prev = newNode;
            } // else, there is nothing to update, so we can do nothing

            // Step (iii) - Update the Head of list (this node is the new first element!)
            Head = newNode;

            // Step (iv) - Update the Tail (only in special situations where the Tail has changed)
            if (Count == 0) //(Tail == null) { } // or Head was null before the update
            {
                // This newNode is the ONLY node in the linked list
                // Which means that we have added the only node in the linked list
                // And it is both the first and last node
                Tail = newNode;
            }

            // Step (v) - Increment Count
            Count++;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="element"></param>
        /// <param name="cursor"></param>
        /// <example>
        /// A -> B -> D -> E
        /// Insert C after B (B is the cursor)
        /// C.Prev = cursor
        /// C.Next = cursor.Next (i.e. D)
        /// </example>
        public void InsertAfter(T element, DoublyLinkedListNode<T> cursor) {

            // Step 0: Validation
            if (cursor == null)
            {
                throw new ArgumentNullException("cursor", "You cannot insert after a null!");
            }

            // Step 1: Build the new Node
            DoublyLinkedListNode<T> newNode = new DoublyLinkedListNode<T>(
                element,
                cursor,
                cursor.Next);

            // Update the references of the cursor and cursor.Next

            // It could happen that the cursor is also the Tail of list...
            // In this case, cursor.Next == null
            // Which means that we do not need to update cursor.Next

#if DEBUG
            if ((cursor.Next == null) != (cursor == Tail))
            {
                // check that everything is fine...
                // Log this and do something...
            }
#endif

            //if (cursor == Tail)
            if (cursor.Next == null)
            {
                // there is no cursor.Next to update
                // However, the new node is now the last node of the linked list
                Tail = newNode; // update the Tail
            } else
            {
                // we know that cursor is not null
                
                // (cursor.Next).Prev = newNode;
                
                DoublyLinkedListNode<T> nodeAfterCursor = cursor.Next;
                nodeAfterCursor.Prev = newNode;

            }

            // update the cursor
            cursor.Next = newNode;

            Count++;
        }

        public void Append(T element)
        {
            if (Tail == null)
            {
                // the linked list is empty
                // Append is equivalent to Insert First
                InsertFirst(element);
            }
            else
            {
                InsertAfter(element, Tail);
            }
        }

        public void InsertBefore(T element, DoublyLinkedListNode<T> cursor)
        {
            throw new NotImplementedException("Exercise");
        }
    }
}
