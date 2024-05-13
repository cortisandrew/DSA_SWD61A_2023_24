using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VectorImplementations
{
    public class SinglyLinkedList<T> : IVectorADT<T>
    {
        Node<T>? head = null;

        Node<T>? tail = null;

        public int Size { get; private set; } = 0;

        public bool IsEmpty 
        { get { return (Size == 0); } }

        public void InsertFirst(T element)
        {
            // Step 1: Create a new node
            Node<T> newNode = new Node<T>(element, null);
            newNode.Next = head;

            if (Size == 0) // || head == null
            {
                // this is the first node to be added...
                // this means that since the linked list will only have 1 node, it is also the tail
                tail = newNode;
            }

            // Step 2: Update the head of list
            head = newNode;

            // Step 3: Increment the size
            Size++;
        }

        public T GetFirstElement()
        {
            if (head == null) // || size == 0
            {
                // there are no elements stored!
                throw new InvalidOperationException("You can't get the first element when the linked list is empty!");
            }

            // head exists
            return head.Element;
        }

        public void Append(T element)
        {
            if (Size == 0) // || head == null
            {
                InsertFirst(element);
                return;
            }

            // Step i: create the new node
            Node<T> newNode = new Node<T>(element, null);

            // Step ii: Find the last node
            //Node<T> lastNode = FindLastNode();
            Node<T>? lastNode = tail;

            // Step iii: Add the new node to the end of the linked list
            // the new node is now the last node in the linked list
            lastNode.Next = newNode;

            // Update tail
            tail = newNode;

            // Step iv:
            Size++;
        }

        private Node<T> FindLastNode()
        {
            if (tail == null)
            {
                throw new InvalidOperationException("The linnked list is empty. There is no last node!");
            }

            return tail;
            /*
            Node<T>? cursor = head;

            if (cursor == null)
            {
                throw new InvalidOperationException("The linnked list is empty. There is no last node!");
            }

            // when cursor is the last node, the next will be null
            // when cursor is NOT the last node, the next will have a reference
            while (cursor.Next != null)
            {
                // this cursor is NOT the last node
                // move forward one step
                cursor = cursor.Next;
            }
            
            // this cursor is not null
            // this cursor has nothing after itself (cursor.Next == null)
            // this is the last node!
            return cursor;
            */
        }

        public T GetLastElement()
        {
            return FindLastNode().Element;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Node<T>? cursor = head;
            while (cursor != null)
            {
                sb.Append(cursor);
                sb.Append(" -> ");
                cursor = cursor.Next;
            }
            sb.AppendLine();

            return sb.ToString();
        }

        public T RemoveHead()
        {
            // Step 0: Validation
            // Check that you have at least one element to return!
            if (head == null) // || size == 0
            {
                throw new InvalidOperationException("There are no elements to remove!");
            }

            // Step i: Get the value you want to return
            T returnElement = head.Element;

            // Extra step
            // Remove the stored information early (instead of waiting for GC)
            // head.Element = default!;
            // or perhaps...
            // head.Dispose();


            // Step ii: Update head of list
            head = head.Next;

            // Step iii: decrement size
            Size--;

            // Step iv: return the value found
            return returnElement;

        }

        public T ElementAtRank(int rank)
        {
            if (rank < 0 || rank >= Size)
            {
                throw new IndexOutOfRangeException("rank does not exist...");
            }

            int currentIndex = 0;
            Node<T>? currentNode = head;

            while (currentIndex < rank)
            {
                if (currentNode == null)
                {
                    throw new IndexOutOfRangeException("index chosen is out of range");
                }

        public T RemoveLast() {

            if (head == null || tail == null)
            {
                // no elements!
                throw new InvalidOperationException();
            }

            T elementToReturn = tail.Element;

            Node<T>? cursor = head; // requires to find node before the tail

            if (cursor == tail)
            {
                // there is only one element!
                head = null;
                tail = null;
                Size--;
                return elementToReturn;
            }

            // there is more than one element
            while (cursor!.Next != tail) // cursor.Next.Next != null (an alternative if you don't have a tail)
            {
                // move forward
                cursor = cursor.Next;
            }

            if (cursor == null)
            {
                // the tail is not in the list!
                // something bad has a happened
                throw new InvalidOperationException();
            }

            // cursor.Next is the tail
            cursor.Next = null; // remove the tail
            tail = cursor;

            Size--;
            return elementToReturn;
        }

                // move forward 1 step
                currentNode = currentNode.Next;
                currentIndex++;
            }

            if (currentNode == null)
            {
                throw new IndexOutOfRangeException("index chosen is out of range");
            }

            // current node is the node at rank
            return currentNode.Element;
        }

        public void InsertAtRank(int rank, T element)
        {
            // find the node at rank (rank - 1) - using a method similar to element at rank
            // InsertAfter
            throw new NotImplementedException();
        }

        public T ReplaceAtRank(int rank, T element)
        {
            throw new NotImplementedException();
        }

        public T RemoveAtRank(int rank)
        {
            throw new NotImplementedException();
        }
    }
}
