﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class LinkList
    {
        public Node Head { get; set; }
        public LinkList Current { get; set; }

        /// <summary>
        /// Creates a link list with one node which is set to head
        /// </summary>
        /// <param name="value">Value of first node to be created for link list</param>
        public LinkList(int value)
        {
            Node node = new Node(value);
            Head = node;
        }

        /// <summary>
        /// Creates new node and puts it at the front of the link list
        /// </summary>
        /// <param name="value"> Value stored in the new node </param>
        public void Insert(int value)
        {
            Node node = new Node(value);
            node.Next = Head;
            Head = node;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Includes(int value)
        {
            Node current = Head;

            while (current != null)
            {
                if (current.Value == value)
                {
                    return true;
                }
                else
                {
                    current = current.Next;
                }
            }
            return false;
        }

        /// <summary>
        /// Display in console the value of each node in linked list
        /// </summary>
        public void Print()
        {
            Node current = Head;

            while (current != null)
            {
                Console.Write($"{current.Value} -> ");
                current = current.Next;
            }

            Console.WriteLine("null");
        }
    }

}