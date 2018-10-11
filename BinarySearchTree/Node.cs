using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node { 

        public Node left { get; set; }
        public Node right { get; set; }
        int value;

        public Node (int value)
        {
            this.value = value;
            left = null;
            right = null;
        }
        
        public int Value
        {
            get => value;
        }

    }
}
