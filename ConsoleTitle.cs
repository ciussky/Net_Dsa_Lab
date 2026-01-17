using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Dsa_Lab
{
    public class ConsoleTitle
    {

        public static void DisplayTitle()
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
    }
}
