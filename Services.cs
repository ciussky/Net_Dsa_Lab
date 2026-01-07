using System.Text.RegularExpressions;

namespace Net_Dsa_Lab
{
    public class Services
    {

        public static int ReadIntegerService(string prompt)
        {
            int result;
            bool isValid = false;

            do
            {
                string input = prompt;

                // Incercam sa convertim input-ul (string) la intreg
                if (int.TryParse(input, out result))
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Enter a valid int.");
                }
            }
            while (!isValid);

            return result;
        }

        public static int[] GenerateRandomArray(int size)
        {
            Random rand = new Random();
            HashSet<int> set = new HashSet<int>();

            while (set.Count < size)
            {
                set.Add(rand.Next(1, 11));
            }

            return set.ToArray();
        }

        public static string RemoveNonAlphanumeric(string input)
        {

            Regex regex = new Regex("[^A-Za-z0-9]");

            return regex.Replace(input, string.Empty).ToLower();

        }
    }
}
