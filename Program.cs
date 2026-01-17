using Net_Dsa_Lab;
using Net_Dsa_Lab.LeetCodeProblems.Easy;
using Net_Dsa_Lab.Menus;
using System;
using System.Collections;
using System.Collections.Generic;


class Program
{

    //public static string Test()
    //{

        //List<int> list = new List<int>();

        //list.Add(5);

        //Hashtable table = new Hashtable();

        //table.Add(1, "2");

        //for (int i = 0; i < 10; i++)
        //{

        //    Console.WriteLine($"i = {i}");
        //    for (int j = i; j < 10; j++)
        //    {
        //        Console.WriteLine($"j = {j}");
        //    }
        //}
        //return Console.ReadLine();

        //string x = "";

        //Console.Write("Enter your height:");

        //x = Console.ReadLine();
        //Console.WriteLine($"Your height is ----> {x}");
        //return Console.ReadLine();

    //}
    static void Main()
    {

        //Test();

        //MergeAlternately("abc", "pqr");

        bool running = true;
        while (running)
        {
            Console.Clear();
            ConsoleTitle.DisplayTitle();
            Console.WriteLine("╔══════════════════════════════════╗");
            Console.WriteLine("║        === Main Menu ===           ");
            Console.WriteLine("╚══════════════════════════════════╝");
            Console.WriteLine("1. Array");
            Console.WriteLine("2. Queue");
            Console.WriteLine("3. Linked List");
            Console.WriteLine("4. LeetCode Problems");
            Console.WriteLine("5. Exit");

            Console.Write("Select an option: ");



            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                   ArrayMenu.Options();
                    break;
                //case "2":
                //    StackMenu();
                //    break;
                //case "3":
                //    QueueMenu();
                //    break;
                case "4":
                    LeetCodeProblems.Options();
                    break;
                //case "5":
                //    BSTMenu();
                //break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    //static void StackMenu()
    //{
    //    // Here you will call methods from the MyStack class
    //}

    //static void QueueMenu()
    //{
    //    // Here you will call methods from the MyQueue class
    //}

    //static void LinkedListMenu()
    //{
    //    // Here you will call methods from the MyLinkedList class
    //}

    //static void BSTMenu()
    //{
    //    // Here you will call methods from the MyBST class
    //}






    //public static string MergeAlternately(string word1, string word2)
    //{

    //}
}
