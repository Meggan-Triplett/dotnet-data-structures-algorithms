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

        static void UserInterface()
        {
            Console.WriteLine("Please choose from one of the following options:");
            Console.WriteLine("1) Insert: Add New Node Into Existing Linked List");
            Console.WriteLine("2) Includes: Check If Given Value Exists in Linked List");
            Console.WriteLine("3) Print: Display Linked List");
            Console.WriteLine("4) Exit");

            string userSelection = Console.ReadLine();
            int actionSelection = Convert.ToInt32(userSelection);

            switch (actionSelection)
            {
                case 1:
                    ViewBalance();
                    ReturnToMenu();
                    break;
                case 2:
                    WithdrawMoney(WithdrawRequest());
                    ReturnToMenu();
                    break;
                case 3:
                    DepositMoney(DepositRequest());
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