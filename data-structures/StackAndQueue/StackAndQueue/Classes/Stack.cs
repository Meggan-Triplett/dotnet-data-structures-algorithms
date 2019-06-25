using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.Classes
{
    public class Stack
    {
        public Node Top { get; set; }

        /// <summary>
        /// Constructor that requires a single value. This will ensure the stack is not empty
        /// </summary>
        /// <param name="value"></param>
        public Stack(int value)
        {
            Node node = new Node(value);
            Top = node;
        }


        /// <summary>
        /// Allows creation of an empty stack
        /// </summary>
        public Stack()
        {

        }

        /// <summary>
        /// Adds a node to the stack
        /// </summary>
        /// <param name="value">Data to be stored in node</param>
        public void Push(int value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// Removes the top node from the stack
        /// </summary>
        /// <returns> The value of the node that was on top of the stack </returns>
        public int Pop()
        {
            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp.Value;
        }

        /// <summary>
        /// Will return the value of the node at the top of the stack
        /// </summary>
        /// <returns> The value of the node that is on top of the stack </returns>
        public int Peek()
        {
            try
            {
                return Top.Value;
            }
            catch (NullReferenceException nre)
            {
                throw new NullReferenceException("No Node Found");
            }
        }


    }

}
