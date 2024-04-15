using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProject
{
    /// <summary>
    /// A Node for a Binary Search Tree, with integer keys
    /// </summary>
    internal class Node<V>
    {
        public Node(int key, V value) {
            this.Key = key;
            this.Value = value;
        }

        internal int Key { get; private set; }
        internal V Value { get; private set; }

        // Being a BINARY tree, each node can have at most 2 children
        // The keys of the Left child and within the Left-subtree are smaller than, or equal to, the key of this node
        // The keys of the Right child and within the Right-subtree are larger than the key of this node

        // If the Left or Right child is null, this means that there is no left or right sub-tree

        internal Node<V>? Left { get; set; }
        internal Node<V>? Right { get; set; }

        /// <summary>
        /// Does this tree contain the key passed as a parameter?
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        internal bool ContainsKey(int key)
        {
            if (Key == key) return true;

            if (key < Key)
            {
                // The key is smaller, so I want to look into the left sub-tree
                // However, there is NO left sub-tree
                // There are no keys that are smaller than the one that this node has
                if (Left == null)
                    return false;

                // The key that we are looking for is SMALLER than my Key
                return Left.ContainsKey(key);
            } else // key > Key
            {
                if (Right == null)
                    return false;

                return Right.ContainsKey(key);
            }
        }

        internal V Search(int key)
        {
            if (Key == key) return Value;

            if (key < Key)
            {
                // The key is smaller, so I want to look into the left sub-tree
                // However, there is NO left sub-tree
                // There are no keys that are smaller than the one that this node has
                if (Left == null)
                    throw new KeyNotFoundException();

                // The key that we are looking for is SMALLER than my Key
                return Left.Search(key);
            }
            else // key > Key
            {
                if (Right == null)
                    throw new KeyNotFoundException();

                return Right.Search(key);
            }
        }

        internal void AddNewChildNode(int key, V value)
        {
            if (key <= Key)
            {
                // if the new key is smaller than, or equal to, the key of this node
                // we want to place the new node as the left child

                if (Left == null)
                {
                    // the Left child is available
                    Left = new Node<V>(key, value);
                    return;
                }
                else // Left is NOT null 
                {
                    // the Left child is occupied
                    // therefore, since the new key has to be placed in the left sub-tree,
                    // I ask the Left child to handle adding the new node
                    Left.AddNewChildNode(key, value);
                    return;
                }
            }
            else // key > Key
            {
                if (Right == null)
                {
                    Right = new Node<V>(key, value);
                    return;
                }
                else // Right is NOT null
                {
                    Right.AddNewChildNode(key, value);
                    return;
                }
            }
        }
    }
}
