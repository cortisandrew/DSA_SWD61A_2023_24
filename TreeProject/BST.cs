using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProject
{
    public class BST<V>
    {
        private Node<V>? root;

        public void AddNewChildNode(int key, V value)
        {
            if (root == null)
            {
                root = new Node<V>(key, value);
            }
            else
            {
                root.AddNewChildNode(key, value);
            }
        }

        public bool ContainsKey(int key)
        {
            if (root == null)
                return false;
            return root.ContainsKey(key);
        }

        public V Search(int key)
        {
            if (root == null)
                throw new KeyNotFoundException();

            return root.Search(key);
        }

        public override string ToString()
        {
            if (root == null)
            {
                return "<EMPTY>";
            }
            return
                "digraph G {" + Environment.NewLine +
                root.ToString()
                 + Environment.NewLine + "}";


        }
    }
}
