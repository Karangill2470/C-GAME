using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;

            while (playAgain)
            {
                Console.WriteLine("Choose ROCK, PAPER, or SCISSORS:");
                string userChoice = Console.ReadLine().ToUpper();

                if (userChoice != "ROCK" && userChoice != "PAPER" && userChoice != "SCISSORS")
                {
                    Console.WriteLine("Choose a valid option.");
                    Console.WriteLine();
                    continue;
                }

                string computerChoice = GetComputerChoice();

                Console.WriteLine("User choice: " + userChoice);
                Console.WriteLine("Computer choice: " + computerChoice);

                string result = DetermineWinner(userChoice, computerChoice);
                Console.WriteLine(result);

                Console.WriteLine("Do you want to play again? (yes/no)");
                string playAgainInput = Console.ReadLine().ToLower();

                if (playAgainInput != "yes")
                {
                    playAgain = false;
                    Console.WriteLine("Thank you for playing!");
                }

                Console.WriteLine();
            }
        }

        static string GetComputerChoice()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 4);

            string computerChoice = "";

            switch (randomNumber)
            {
                case 1:
                    computerChoice = "ROCK";
                    break;
                case 2:
                    computerChoice = "PAPER";
                    break;
                case 3:
                    computerChoice = "SCISSORS";
                    break;
            }

            return computerChoice;
        }

        static string DetermineWinner(string userChoice, string computerChoice)
        {
            if (userChoice == computerChoice)
            {
                return "It's a tie";
            }
            else if (
                (userChoice == "ROCK" && computerChoice == "SCISSORS") ||
                (userChoice == "PAPER" && computerChoice == "ROCK") ||
                (userChoice == "SCISSORS" && computerChoice == "PAPER")
                )
            {
                return "User Wins";
            }
            else
            {
                return "Computer Wins";
            }
        }
    }
}
