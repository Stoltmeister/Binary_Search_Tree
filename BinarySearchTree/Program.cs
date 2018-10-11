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
            Tree binarySearchTree = new Tree(5);
            Random r = new Random();
            for (int i = 0; i < 20; i++)
            {
                binarySearchTree.Add(r.Next(1, 11));
            }
            binarySearchTree.Search(binarySearchTree.Root, 9);
            Console.ReadLine();
            //binarySearchTree
            
        }
    }
}
