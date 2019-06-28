using System;
using LinkedList.Classes;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ConsoleLinkedList();
        }

        static void ConsoleLinkedList()
        {
            LinkList list = new LinkList(9);

            list.Insert(42);
            list.Insert(6);
            list.Insert(1);
        }


    }
}