using Net_Dsa_Lab.LeetCodeProblems.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Dsa_Lab.Menus
{
    public class LeetCodeProblems
    {
        public static void Options()
        {

            EasyLeetCodeProblems leet = new EasyLeetCodeProblems();

            bool back = false;
            while (!back)
            {
                Console.Clear();
                ConsoleTitle.DisplayTitle();

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
                    case "4":
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
    }
}
