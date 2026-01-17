using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Dsa_Lab.Menus
{
    public class ArrayMenu
    {
        public static void Options()
        {

            ArrayHandler arr = new ArrayHandler();
            bool back = false;

            while (!back)
            {
                Console.Clear();
                ConsoleTitle.DisplayTitle();

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
                        int num;
                        Console.Write("Value: ");
                        while (!int.TryParse(Console.ReadLine(), out num))
                        {
                            Console.WriteLine("Invalid input. Please enter a whole number.");
                            Console.Write("Value: ");
                        }
                        arr.Add(num);
                        Console.ReadLine();

                        break;
                    case "2":
                        Console.WriteLine($"There are {arr.Count().ToString()} elements in array.");

                        Console.Write("Set index: ");
                        int idxInsert = int.Parse(Console.ReadLine());
                        Console.Write("Set value: ");
                        int valInsert = int.Parse(Console.ReadLine());
                        arr.InsertAt(idxInsert, valInsert);
                        break;

                    case "3":
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
    }
}
