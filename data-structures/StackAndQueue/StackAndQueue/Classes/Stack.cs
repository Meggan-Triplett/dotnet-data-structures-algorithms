using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.Classes
{
    public class Stack
    {
        public Node Top { get; set; }

        public Stack(int value)
        {
            Node node = new Node(value);
            Top = node;
        }

        public Stack()
        {

        }

        public void Push(int value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
        }

        public int Pop()
        {
            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp.Value;
        }

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
