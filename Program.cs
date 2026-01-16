using Net_Dsa_Lab;
using Net_Dsa_Lab.LeetCodeProblems.Easy;
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
            DisplayTitle();
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
                    ArrayMenu();
                    break;
                //case "2":
                //    StackMenu();
                //    break;
                //case "3":
                //    QueueMenu();
                //    break;
                case "4":
                    LeetCodeProblemsMenu();
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

    static void LeetCodeProblemsMenu()
    {

        EasyLeetCodeProblems leet = new EasyLeetCodeProblems();

        bool back = false;
        while (!back)
        {
            Console.Clear();
            DisplayTitle();

            Console.WriteLine("=== LeetCode Problems Menu ===");
            Console.WriteLine("1. TwoSum(nums, target) ");
            Console.WriteLine("2. IsPalindromeNumber(int x) ");
            Console.WriteLine("3. IsPalindromeString(string s) ");
            Console.WriteLine("4. SingleNumber(nums) ");
            Console.WriteLine("5. Back");
            Console.Write("Choose an option: ");

            //options
            string opt = Console.ReadLine();
            Console.WriteLine();
            switch (opt)
            {
                case "1":

                    var nums = Services.GenerateRandomArray(10);
                    Console.WriteLine($"Generated array: [{string.Join(", ", nums)}]");

                    Console.Write("Input target (sum two numbers from array): ");
                    int target;
                    while (!int.TryParse(Console.ReadLine(), out target))
                    {
                        Console.WriteLine("Invalid input. Please enter a whole number.");
                        Console.Write("Input target (sum two numbers from array): ");
                    }

                    int[] result = EasyLeetCodeProblems.FindTwoSum(nums, target);
                    Console.Write($"result: [{string.Join(", ", result)}]");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.Write("Input number to check if palindrome: ");
                    int x;
                    while (!int.TryParse(Console.ReadLine(), out x))
                    {
                        Console.WriteLine("Invalid input. Please enter a whole number.");
                        Console.Write("Input number to check if palindrome: ");
                    }
                    bool isPalindrome = EasyLeetCodeProblems.IsPalindromeNumber(x);
                    Console.WriteLine($"Is {x} a palindrome? {isPalindrome}");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.Write("Input string to check if palindrome: ");
                    string s = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(s))
                    {
                        Console.WriteLine("Invalid input. Please enter a non-empty string.");
                        Console.Write("Input string to check if palindrome: ");
                        s = Console.ReadLine();
                    }
                    bool isPalindromeString = EasyLeetCodeProblems.IsPalindromeString(s);
                    Console.WriteLine($"Is {s} a palindrome? {isPalindromeString}");
                    Console.ReadLine();
                    break;
                    case"4":
                    nums = Services.GenerateRandomArray(10);
                    nums = [2, 5, 2];
                    Console.WriteLine($"Hardcoded array: [{string.Join(", ", nums)}]");

                    int? singleNumber = EasyLeetCodeProblems.SingleNumber(nums);
                    if (singleNumber == null)
                    {
                        Console.WriteLine("No single number found");
                    }
                    else
                    {
                        Console.WriteLine($"The single number is {singleNumber}");
                    }

                    Console.ReadLine();
                    break;
                case "5":
                    back = true;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
            Console.WriteLine();
        }
    }

    static void ArrayMenu()
    {

        Console.Clear();
        ArrayHandler arr = new ArrayHandler();
        bool back = false;

        while (!back)
        {
            Console.WriteLine("=== Array Menu ===");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. InsertAt");
            Console.WriteLine("3. RemoveAt");
            Console.WriteLine("4. GetAt");
            Console.WriteLine("5. Print");
            Console.WriteLine("6. Back");
            Console.Write("Choose: ");

            string opt = Console.ReadLine();
            Console.WriteLine();

            switch (opt)
            {
                case "1":
                    Console.Clear();
                    int num;
                    Console.Write("Value: ");
                    while (!int.TryParse(Console.ReadLine(), out num))
                    {
                        Console.WriteLine("Invalid input. Please enter a whole number.");
                        Console.Write("Value: ");
                    }
                    arr.Add(num);
                    break;
                case "2":
                    Console.Clear();

                    Console.WriteLine($"There are {arr.Count().ToString()} elements in array.");

                    Console.Write("Set index: ");
                    int idxInsert = int.Parse(Console.ReadLine());
                    Console.Write("Set value: ");
                    int valInsert = int.Parse(Console.ReadLine());
                    arr.InsertAt(idxInsert, valInsert);
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine($"Updated array is: [{arr.ArrItems()}]");
                    Console.Write("Index: ");
                    arr.RemoveAt(int.Parse(Console.ReadLine()));
                    break;

                case "4":
                    Console.Write("Index: ");
                    arr.GetAt(int.Parse(Console.ReadLine()));
                    break;

                case "5":
                    arr.Print();
                    break;

                case "6":
                    back = true;
                    break;

                default:
                    Console.WriteLine("Optiune invalida.");
                    break;
            }

            Console.WriteLine();
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


    static void DisplayTitle()
    {
        // Textul in ASCII Art pentru "DSA LAB"
        string titleArt = @"
  _____     _____                        _           ____  
 |  __ \   / ____|    /\                | |         |  _ \ 
 | |  | | | (___     /  \               | |     __ _| |_) |
 | |  | |  \___ \   / /\ \              | |    / _` |  _ < 
 | |__| |  ____) | / ____ \             | |___| (_| | |_) |
 |_____/  |_____/ /        \ __________ |______\__,_|____/
";

        // Setam Culoarea
        Console.ForegroundColor = ConsoleColor.Green;

        // Extragem fiecare linie
        string[] lines = titleArt.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

        // Determinăm lățimea consolei
        int consoleWidth = Console.WindowWidth;

        // Găsim lățimea maximă a textului ASCII Art pentru centrare
        int maxLineWidth = 0;
        foreach (string line in lines)
        {
            if (line.Length > maxLineWidth)
            {
                maxLineWidth = line.Length;
            }
        }

        // Afișăm fiecare linie centrat
        foreach (string line in lines)
        {
            // Calculam spatiul necesar pentru a centra
            int padding = (consoleWidth - maxLineWidth) / 2;
            if (padding < 0) padding = 0; // Previne crash daca consola e prea mica

            string centeredLine = new string(' ', padding) + line;
            Console.WriteLine(centeredLine);
        }

        // Resetam Culoarea
        Console.ResetColor();

        Console.WriteLine("\n" + new string('—', consoleWidth)); // Linie separatoare
    }



    //public static string MergeAlternately(string word1, string word2)
    //{

    //}
}
