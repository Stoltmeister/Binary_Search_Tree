﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node { 

        public Node left;
        public Node right;
        public Node parent;
        int value;

        public Node (int value)
        {
            this.value = value;
            left = null;
            right = null;
            parent = null;
        }
        
        public int Value
        {
            get => value;
        }

    }
}
