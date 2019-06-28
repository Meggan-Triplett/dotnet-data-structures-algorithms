using System;
using LinkedList.Classes;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface();
        }

        static void ConsoleLinkedList()
        {
            LinkList list = new LinkList(9);

            list.Insert(42);
            list.Insert(6);
            list.Insert(1);
        }

        static void UserInterface()
        {
            Console.WriteLine("Please choose from one of the following options:");
            Console.WriteLine("1) Insert: Add New Node Into Existing Linked List");
            Console.WriteLine("2) Includes: Check If Given Value Exists in Linked List");
            Console.WriteLine("3) Print: Display a Linked List");
            Console.WriteLine("4) Exit");

            string userSelection = Console.ReadLine();
            int actionSelection = Convert.ToInt32(userSelection);

            switch (actionSelection)
            {
                case 1:
                    InsertToLinkedList();
                    ReturnToMenu();
                    break;
                case 2:
                    IncludedInLinkList();
                    ReturnToMenu();
                    break;
                case 3:
                    LinkList linkedlist = new LinkList(9);
                    linkedlist.Insert(42);
                    linkedlist.Insert(6);
                    linkedlist.Insert(1);

                    linkedlist.Print();

                    ReturnToMenu();
                    break;
                case 4:
                    Exit();
                    break;
                default:
                    Exit();
                    break;
            }
        }

        static void InsertToLinkedList()
        {
            LinkList linkedlist = new LinkList();

            Console.WriteLine("Please enter what value you would like the new node to have.");

            string userResponse = Console.ReadLine();
            int newNodeValue = Convert.ToInt32(userResponse);

            linkedlist.Insert(newNodeValue);

            Console.WriteLine();
            linkedlist.Print(); 
        }

        static void IncludedInLinkList()
        {
            LinkList linkedlist = new LinkList(9);

            linkedlist.Insert(42);
            linkedlist.Insert(6);
            linkedlist.Insert(1);

            Console.WriteLine("Please enter what value you would like to check if it exists on the linked list.");

            string userResponse = Console.ReadLine();
            int searchValue = Convert.ToInt32(userResponse);

            Console.WriteLine();
            Console.WriteLine(linkedlist.Includes(searchValue));
        }

        static void ReturnToMenu()
        {
            Console.WriteLine("Would you like to return to menu? (Y/N)");

            string userResponse = Console.ReadLine();
            string userDecision = userResponse.ToUpper();

            if (userDecision == "Y")
            {
                UserInterface();
            }
            else if (userDecision == "N")
            {
                Exit();
            }
            else
            {
                UserInterface();
            }
        }

        static void Exit()
        {
            Environment.Exit(0);
        }

    }
}