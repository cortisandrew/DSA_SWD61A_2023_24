using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VectorImplementations
{
    public class SinglyLinkedList<T> // : IVectorADT<T>
    {
        Node<T>? head = null;

        Node<T>? tail = null;

        public int Size { get; private set; } = 0;

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

        public Node<T> GetFirstNode()
        {
            if (head == null) // || size == 0
            {
                // there are no elements stored!
                throw new InvalidOperationException("You can't get the first element when the linked list is empty!");
            }

            // head exists
            return head;
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

            if (head == null) // we have just removed the last element (which also happened to be the tail)
            {
                tail = null; // there now no elements in the linked list!
            }

            // Step iii: decrement size
            Size--;

            // Step iv: return the value found
            return returnElement;

        }

        public void InsertAfter(Node<T> currentNode, T element)
        {
            // Validation
            if (currentNode == null)
            {
                throw new ArgumentNullException("currentNode", "Cannot insert after a NULL!");
            }

            // Step 0
            if (currentNode == tail)
            {
                // We know how to insert after the tail: this is the Append
                Append(element);
                return;
            }

            // Step 1 - build new info
            Node<T> newNode = new Node<T>(element, currentNode.Next);

            // Step 2 - update existing references
            currentNode.Next = newNode;

            // Step 3 - Increment size
            Size++;
        }

        public T RemoveAfter(Node<T> currentNode)
        {
            // Validation
            if (currentNode == null)
            {
                throw new ArgumentNullException("currentNode", "Cannot remove after a NULL!");
            }

            if (currentNode == tail)
            {
                throw new ArgumentException("currentNode", "You cannot remove after the last node!");
            }

            if (currentNode.Next == null)
            {
                throw new ApplicationException("There is some bug in the code! The currentNode.Next is null when the currentNode is NOT the tail!");
            }

            // Main code here...
            Node<T> nodeToRemove = currentNode.Next; // Exclamation mark causes warning to switch off. i.e. I know about this and we have our validation
            T elementToReturn = nodeToRemove.Element;

            currentNode.Next = nodeToRemove.Next;

            // The below is identical to the above
            // currentNode.Next = (currentNode.Next).Next;

            // Special condition
            // After the update above, the current node has no next element
            // This happens if we have just removed the tail
            // Therefore, the currentNode becomes the tail!
            if (currentNode.Next == null)
            {
                tail = currentNode;
            }

            Size--;
            return elementToReturn;
        }
    }
}
