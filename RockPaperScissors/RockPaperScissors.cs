using System;


namespace ConsoleApp5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string Rock = "Rock";
            string Paper = "Paper";
            string Scissors = "Scissors";
            string computerMove = "";
            int playerScore = 0;
            int computerScore = 0;

            bool continuePlaying = true;

            while (continuePlaying)
            {
                Console.WriteLine("Choose {r}ock, {p}aper or {s}cissors");
                string playerMove = Console.ReadLine();

                if (playerMove == "r" || playerMove == "rock")
                {
                    playerMove = Rock;
                }

                else if (playerMove == "p" || playerMove == "paper")
                {
                    playerMove = Paper;
                }

                else if ((playerMove == "s" || playerMove == "scissors"))
                {
                    playerMove = Scissors;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid Input. Try Again...");
                    Console.ResetColor();
                    return;
                }

                Random random = new Random();
                int computerRandomNumber = random.Next(1, 4);

                switch (computerRandomNumber)
                {
                    case 1:
                        computerMove = Rock;
                        break;
                    case 2:
                        computerMove = Paper;
                        break;
                    case 3:
                        computerMove = Scissors;
                        break;
                }

                Console.WriteLine($"The computer chose {computerMove}.");

                if ((playerMove == Rock && computerMove == Scissors || playerMove == Paper && computerMove == Rock || playerMove == Scissors && computerMove == Paper))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You win.");
                    playerScore++;
                }

                else if ((computerMove == Rock && playerMove == Scissors || computerMove == Paper && playerMove == Rock || computerMove == Scissors & playerMove == Paper))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You lose.");
                    computerScore++;
                }
                
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("The game is a draw.");
                }
                Console.ResetColor();

                Console.WriteLine($"Player Score: {playerScore}  Computer Score: {computerScore}");
                
                Console.WriteLine("Do you want to continue playing? (Y/N)");
                string choice = Console.ReadLine().ToUpper();

                if (choice != "Y")
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Thank you for playing!");
                    continuePlaying = false;
                }
                else
                {
                    Console.Clear();
                }
                Console.ResetColor();

            }
        }
    }
}
