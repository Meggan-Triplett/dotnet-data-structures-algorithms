using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree()
        {

        }

        public BinaryTree(int value)
        {
            Node node = new Node(value);
            Root = node;
        }


    }
}
