using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Character_Access
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[3];

            Console.WriteLine("Enter 3 names:");

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Name {i + 1}: ");
                names[i] = Console.ReadLine();
            }

            Console.WriteLine("\nResults:");

            foreach (string name in names)
            {
                if (!string.IsNullOrEmpty(name)) // Check if the name is not empty
                {
                    char firstChar = name[0]; // Get the first character
                    char lastChar = name[name.Length - 1]; // Get the last character
                    string upperFirstChar = char.ToUpper(firstChar).ToString(); // Uppercase first character
                    string upperLastChar = char.ToUpper(lastChar).ToString(); // Uppercase last character

                    // Print the results
                    Console.WriteLine($"Original Name: {name}");
                    Console.WriteLine($"First Character: {firstChar} (Uppercase: {upperFirstChar})");
                    Console.WriteLine($"Last Character: {lastChar} (Uppercase: {upperLastChar})");
                    Console.WriteLine(); // Blank line for better readability
                }
                else
                {
                    Console.WriteLine("Name cannot be empty.");
                }

            }
        }
    }
}
