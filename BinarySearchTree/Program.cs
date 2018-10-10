using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree binarySearchTree = new Tree();
            Node root = null;

            binarySearchTree.Add(root, 50);
            Random r = new Random();
            for (int i = 0; i < 20; i++)
            {                
                root = binarySearchTree.Add(root, r.Next(1, 100));
            }
            binarySearchTree.Search(root);
            //binarySearchTree
            
        }
    }
}
