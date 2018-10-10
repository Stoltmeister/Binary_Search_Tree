using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Tree<T>
    {
        private Node root;

        public Tree(int value)
        {
            root = new Node(value);
        }
        public void Add(Node currentNode, int value)
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
            }            
        }

        public void Search(Node node, int value)
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
                Search(node.left, value);
            }
            else if (node.right.Value < value)
            {
                Search(node.right, value);
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
