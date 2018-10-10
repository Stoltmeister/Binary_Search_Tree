using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Tree
    {
        private Node root;

        public Tree(int value)
        {
            root = new Node(value);
        }

        public void Add(int value)
        {
            Add(root, value);
        }

        private void Add(Node currentNode, int value)
        {
            if (currentNode == null)
            {
                Node newNode = new Node(value);
            }
            else if (value < currentNode.Value)
            {
                Add(root.left, value);
                return;
            }
            else if (value >= currentNode.Value)
            {
                Add(root.right, value);
                return;
            }
        }

        public void Search(int value, Node node = null)
        {
            if (node == null)
            {
                Console.WriteLine("Not Found!");
                return;
            }
            else if (node.left.Value == value || node.right.Value == value || node.Value == value)
            {
                Console.WriteLine("Found!");
                return;
            }
            else if (value < node.left.Value)
            {
                Search(value, node.left);
            }
            else if (node.right.Value < value)
            {
                Search(value, node.right);
            }
            else
            {
                Console.WriteLine("Not Found!");
                return;
            }

        }



    }
}
}
