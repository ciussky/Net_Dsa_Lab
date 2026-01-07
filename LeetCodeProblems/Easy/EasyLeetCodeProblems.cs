using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Net_Dsa_Lab.LeetCodeProblems.Easy
{
    public class EasyLeetCodeProblems
    {
        public static int[] FindTwoSum(int[] nums, int target)
        {
            var map = new Dictionary<int, int>(); // nr -> index

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];


                if (map.ContainsKey(complement))
                {
                    Console.WriteLine($"Found Complement - Nums: {complement} and {nums[i]}");
                    return new int[] { map[complement], i };
                }

                if (!map.ContainsKey(nums[i]))
                {
                    Console.WriteLine($"Added to map - Index: {i}, Num: {nums[i]}");
                    map.Add(nums[i], i);
                }
            }

            return Array.Empty<int>();

            //second approach
            //var map = new Dictionary<int, int>();

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int complement = target - nums[i];

            //    // 1. Verificam daca am vazut deja complementul
            //    if (map.TryGetValue(complement, out int index))
            //    {
            //        return new int[] { index, i };
            //    }

            //    // 2. Adaugam numarul curent in dictionar daca nu exista deja
            //    // Folosim TryAdd pentru a preveni exceptii in caz de duplicate care nu sunt solutia
            //    map.TryAdd(nums[i], i);
            //}

            //return Array.Empty<int>();

            //    for (int i = 0; i < nums.Length; i++)
            //    {
            //        for (int j = i + 1; j < nums.Length; j++)
            //        {
            //            if (nums[i] + nums[j] == target)
            //            {
            //                return new int[] { i, j };
            //            }
            //        }
            //    }
            //    return Array.Empty<int>();
        }

        public static bool IsPalindromeNumber(int x)
        {
            //if (x < 0) return false;

            //char[] digits = x.ToString().ToCharArray();

            //Array.Reverse(digits);

            //try
            //{
            //    // Această linie aruncă OverflowException
            //    int reversed = int.Parse(new string(digits));

            //    return x == reversed;
            //}
            //catch (OverflowException)
            //{
            //    return false;
            //}


            ////solution 2
            //if (x < 0 || (x % 10 == 0 && x != 0))
            //{
            //    return false;
            //}

            //int reversed = 0;

            //while (x > reversed)
            //{

            //    //extragem ultima jumatate a nr. plus impariul daca e
            //    reversed = reversed * 10 + x % 10;

            //    //taiem ultima cifra din x
            //    x = x / 10;
            //}

            ////daca are cifre pare sau impare, reversed / 10 taie ultima cifra deoarece e int! 12.3 devine 12
            //return x == reversed || x == reversed / 10;

            ////solution 3
            if (x < 0) return false;  // negative numbers not allowed

            string s = x.ToString();  // transformăm numărul în string
            int n = s.Length;

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine($"Comparing nums: {s[i]} == {s[n - 1 - i]}");

                if (s[i] != s[n - 1 - i])
                    return false;  // dacă cifrele de la capete nu se potrivesc
            }

            return true;  // toate cifrele s-au potrivit
        }

        public static bool IsPalindromeString(string s)
        {

            s = Services.RemoveNonAlphanumeric(s);
            int n = s.Length;

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine($"Comparing nums: {s[i]} == {s[n - 1 - i]}");
                if (s[i] != s[n - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }


        public static int? SingleNumber(int[] nums)
        {

            //var result = 0;

            //foreach (var item in nums)
            //{
            //    Console.WriteLine($"Comparing bits of: {result} and {item}");

            //    result ^= item;
            //}

            //return result;



            var counts = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (!counts.ContainsKey(num))
                    counts[num] = 0;

                counts[num]++;
            }

            foreach (var kv in counts)
            {
                if (kv.Value == 1)
                    return kv.Key;
            }

            return null;

        }
    }
}
