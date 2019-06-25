using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.Classes
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        /// <summary>
        /// Create a node
        /// </summary>
        /// <param name="value"> Value of node that will be created </param>
        public Node(int value)
        {
            Value = value;
        }
    }

}