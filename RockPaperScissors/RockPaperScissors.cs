using System;


namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string Rock = "Rock";
            string Paper = "Paper";
            string Scissors = "Scissors";
            string computerMove = "";

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
                Console.WriteLine("Invalid Input. Try Again...");  
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

            if ((playerMove == Rock && computerMove== Scissors || playerMove == Paper && computerMove == Rock || playerMove == Scissors && computerMove == Paper))
            {
                Console.WriteLine("You win.");
            }

            else if ((computerMove == Rock && playerMove == Scissors || computerMove == Paper && playerMove == Rock || computerMove == Scissors & playerMove == Paper))
            {
                Console.WriteLine("You lose.");
            }

            else
            {
                Console.WriteLine("The game is a draw.");
            }


        }
    }
}
