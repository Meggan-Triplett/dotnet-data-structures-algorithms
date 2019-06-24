using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.Classes
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        public Queue(int value)
        {
            Node node = new Node(value);
            Front = node;
            Rear = node;
        }

        //To initialize with nothing in queue
        public Queue()
        {

        }

        public void Enqueue(int value)
        {
            Node node = new Node(value);
            node.Next = Rear;
            Rear = node;
        }

        public int Dequeue()
        {
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp.Value;
        }

        public int Peek()
        {
            try
            {
                return Front.Value;
            }
            catch(NullReferenceException nre)
            {
                throw new NullReferenceException("Front not found");
            }
        }

    }

}
