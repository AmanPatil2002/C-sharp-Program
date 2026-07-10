
using System;

namespace _20th
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String compter;
            String answer;

            while (playAgain)
            {
                player = "";
                compter = "";
                answer = "";

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.Write("Enter ROCK, PAPER, or SCISSORS : ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                switch (random.Next(1, 4))
                {
                    case 1:
                        compter = "ROCK";
                        break;
                    case 2:
                        compter = "PAPER";
                        break;
                    case 3:
                        compter = "SCISSORS";
                        break;
                }
                Console.WriteLine("Player : " + player);
                Console.WriteLine("Computer : " + compter);

                switch (player)
                {
                    case "ROCK":
                        if  (compter == "ROCK")
                        {
                            Console.WriteLine("It's a draw ! ");
                        }
                        else if (compter == "PAPER")
                        {
                            Console.WriteLine("You Lose");
                        }
                        else
                        {
                            Console.WriteLine("...............You Win...............");
                        }
                        break;
                    case "PAPER" :
                        if(compter == "ROCK")
                        {
                            Console.WriteLine("...............You Win...............");
                        }
                        else if (compter == "PAPER")
                        {
                            Console.WriteLine("It's a draw ! ");
                        }
                        else
                        {
                            Console.WriteLine("You Lose");
                        }
                        break;
                    case "SCISSORS":
                         if (compter == "ROCK")
                        {
                            Console.WriteLine("You Lose");
                        }
                        else if (compter == "PAPER")
                        {
                            Console.WriteLine("...............You Win...............");
                        }
                        else
                        {
                            Console.WriteLine("It's a draw ! ");
                        }
                        break;
                }
                Console.Write("Would you like to play again (Y/N) : ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    playAgain = true;
                }
                else if (answer == "N")
                {
                    playAgain = false;
                }
            }
            Console.WriteLine("Thanks for playing ");

            Console.ReadKey();
        }
    }
}