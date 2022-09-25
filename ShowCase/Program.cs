using System;

// The curly underlined "UtilityLibraries" namespace states we have to add reference to a library with the same namespace
using UtilityLibraries;

// The program prompts the user to enter a string.
// It indicates whether the string starts with an uppercase character.
// If the user presses the enter key without entering a string, the application ends, and the console window closes.

// The code uses the row variable to maintain a count of the number of rows of data written to the console window.
// Whenever it's greater than or equal to 25, the code clears the console window and displays a message to the user.
class Program
{
    static void Main(string[] args)
    {
        int row = 0;

        do
        {
            if (row == 0 || row >= 25)
                ResetConsole();

            // The question mark (?) after string in the C# code indicates that the string may be null.
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;
            Console.WriteLine($"Input: {input} {"Begins with uppercase? ",30}: " +
                              $"{(input.StartsWithUpper() ? "Yes" : "No")}{Environment.NewLine}");
            row += 3;
        } while (true);
        return;

        // Declare a ResetConsole local method
        void ResetConsole()
        {
            if (row > 0)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine($"{Environment.NewLine}Press <Enter> only to exit; otherwise, enter a string and press <Enter>:{Environment.NewLine}");
            row = 3;
        }
    }
}