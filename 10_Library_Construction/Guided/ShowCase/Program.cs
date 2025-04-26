using System;
using UtilityLibraries;

class Program
{
    static void Main(string[] args)
    {
        int row = 0;

        do
        {
            // Reset the console when row is 0 or greater than or equal to 25
            if (row == 0 || row >= 25)
                ResetConsole();

            // Read user input
            string input = Console.ReadLine();

            // Exit the loop if input is empty or null
            if (string.IsNullOrEmpty(input)) break;

            // Display the input and whether it starts with an uppercase letter
            Console.WriteLine($"Input: {input} {"Begins with uppercase?",30}: " +
                              $"{(input.StartsWithUpper() ? "Yes" : "No")}\n");

            row += 3;

        } while (true);

        // Declare a ResetConsole local method
        void ResetConsole()
        {
            if (row > 0)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }

            Console.Clear();
            Console.WriteLine("\nPress <Enter> only to exit; otherwise, enter a string and press <Enter>:\n");
            row = 3;
        }
    }
}
