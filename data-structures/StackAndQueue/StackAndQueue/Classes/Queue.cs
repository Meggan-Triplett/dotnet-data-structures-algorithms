using System;
//using System.Collections.Generic;
using System.Text;
using StackAndQueue.Classes;

namespace StackAndQueue.Classes
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        /// <summary>
        /// Initializes queue with a single node
        /// </summary>
        /// <param name="value"> Value of node that will be created </param>
        public Queue(int value)
        {
            Node node = new Node(value);
            Front = node;
            Rear = node;
        }

        /// <summary>
        /// To initialize an empty queue
        /// </summary>
        public Queue()
        {

        }

        /// <summary>
        /// Add a node to the rear of the queue
        /// </summary>
        /// <param name="value"> The value of the node that will be created </param>
        public void Enqueue(int value)
        {
            Node node = new Node(value);
            node.Next = Rear;
            Rear = node;
        }
        
        /// <summary>
        /// Remove a node from the front of the queue
        /// </summary>
        /// <returns> The value of node that is being removed </returns>
        public int Dequeue()
        {
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp.Value;
        }

        /// <summary>
        /// View the value of the node at the front of the queue
        /// </summary>
        /// <returns> The value of the node at the front of the queue </returns>
        public int Peek()
        {
            try
            {
                return Front.Value;
            }
            catch (NullReferenceException nre)
            {
                throw new NullReferenceException("Front not found");
            }
        }

    }

}
