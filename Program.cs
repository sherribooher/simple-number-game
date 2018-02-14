using System;

namespace NumberGame
{
    // Main class
    class Program
    {
        // Entry point method with return type void (nothing returned)
        static void Main(string[] args)
        {
            // Print app info
            GetAppInfo();

            // Get user's name and print greeting
            GreetUser();

            // Allow user to play again
            while (true)
            {

                // Create a new random number object
                Random random = new Random();

                // Set correct number to a random number
                int correctNumber = random.Next(1, 11);

                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess the number between 1 and 10");

                // While guess is not correct, prompt user to keep guessing
                while (guess != correctNumber)
                {
                    // Get user's guess input
                    string input = Console.ReadLine();

                    // Check input to make sure it is a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please enter a valid number!");
                        
                        // Continue
                        continue;

                    }

                    // Cast to int and put in guess var
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Set error message color and print
                        PrintColorMessage(ConsoleColor.Red, "Wrong number! Please try again!");

                    }

                }
                
                // Set success message color and print
                PrintColorMessage(ConsoleColor.Yellow, "You guessed the number!");

                // Ask user if they want to play again
                Console.WriteLine("Play Again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                // Check answer
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }

        }

        // Get and display app info
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Game";
            string appVersion = "1.0.0";
            string appAuthor = "Sherri Booher";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write first line app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Set color back to default
            Console.ResetColor();

        }

        // Ask users name and greet them
        static void GreetUser()
        {
            // Prompt for user name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            // Greet the user
            Console.WriteLine("Hello {0}, let's play a game!", inputName);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color for error message
            Console.ForegroundColor = color;

            // Write out error message
            Console.WriteLine(message);

            // Reset test color
            Console.ResetColor();

        }
    }
}
