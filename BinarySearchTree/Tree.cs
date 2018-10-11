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

        public Node Root
        {
            get => root;
        }

        public void Add(int value)
        {
            Node newNode = new Node(value);
            Node currentNode = root;
            Node parent = null;

            while (currentNode != null)
            {
                parent = currentNode;

                if (value < currentNode.Value)
                {
                    currentNode = currentNode.left;
                    if (currentNode == null)
                    {
                        parent.left = newNode;
                    }                    
                }
                else
                {
                    currentNode = currentNode.right;
                    if (currentNode == null)
                    {
                        parent.right = newNode;
                    }
                }
            }
        }

        public void Search(Node root, int value)
        {            
            if (root != null)
            {
                Search(root.left, value);
                Search(root.right, value);
                if (root.Value == value)
                {
                    Console.WriteLine("Value exists!");
                    return;
                }
            } 
        }
    }
}

