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

        //TODO preOrder traversal method
        public void PreOrder(Node node, List<int> treeNodes)
        {
            treeNodes.Add(node.Value);

            if (node.Left != null)
            {
                PreOrder(node.Left, treeNodes);
            }
            if (node.Right != null)
            {
                PreOrder(node.Right, treeNodes);
            }
        }

        public List<int> PreOrder(Node node)
        {
            List<int> treeNodes = new List<int>();
            PreOrder(node, treeNodes);
            return treeNodes;
        }

        //TODO inOrder traversal method

        //TODO postOrder traversal method

    }
}
