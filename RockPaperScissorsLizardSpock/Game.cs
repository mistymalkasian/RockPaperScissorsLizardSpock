using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {
       Player Player1;
       Player Player2;

        public void RunPreliminaries()
        {
            DisplayRules();
            DecideOpponent();
 
        }

        private void DisplayRules()
        {
            Console.WriteLine("");
            Console.WriteLine("=========================");
            Console.WriteLine("=================");
            Console.WriteLine("========");
            Console.WriteLine("==");
            Console.WriteLine("You are playing \"Rock Paper Scissors Lizard Spock\"");
            Console.WriteLine("These are the rules: ");
            Console.WriteLine("Scissors cuts paper");
            Console.WriteLine("Paper covers rock");
            Console.WriteLine("Rock crushes lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes scissors");
            Console.WriteLine("Scissors decapitates lizard");
            Console.WriteLine("Lizard eats paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes rock");
            Console.WriteLine("and (as it always has,) rock crushes scissors.");
            Console.WriteLine("==");
            Console.WriteLine("========");
            Console.WriteLine("=================");
            Console.WriteLine("=========================");
            Console.WriteLine("");
            Console.WriteLine("Best 3 out of 5 will be the winner!");
            Console.WriteLine("Please press ENTER to continue.");
            Console.ReadLine();

        }

        private void DecideOpponent()

        {
            Console.Clear();
            Console.WriteLine("Will you be playing against another player? Type 1 if yes, 2 if no.");
            int PlayerAnswer = 0;

            try
            {
                PlayerAnswer = Convert.ToInt32(Console.ReadLine());
            }

            catch (Exception)
            {
                Console.WriteLine("Invalid input. Please only choose either 1 or 2.");
                Console.ReadLine();
                DecideOpponent();

            }
            switch (PlayerAnswer)
            {
                case 1:
                    Player1 = new Player();
                    Player2 = new Player();
                    AskForName();

               
                    break;

                case 2:
                    Player1 = new Player();
                    Player2 = new CPU();
                    DisplayCPUMessage();

                    break;

                default:
                    Console.WriteLine("You have made an invalid selection. Please only choose either 1 or 2.");
                    Console.ReadLine();
                    DecideOpponent();
                    break;

            }
        }

        private void AskForName()

        {
            Console.WriteLine("Player1, what is your name?");

            Player1.name = Console.ReadLine();

            Console.WriteLine("Player2, what is your name?");

            Player2.name = Console.ReadLine();

            Console.Clear();
            RunRound();

        }

        private void RunRound()
        {
            Player1.PlayerChoose(Player1);
            Player2.PlayerChoose(Player2);
            DetermineRoundWinner();

        }
        private void AddToScore(Player player)
        {
           player.score += 1;

        }
        private void DisplayCPUMessage()
        {
            Console.WriteLine("Very well, you may play against the Computer! The Computer is very excited to begin.");
            Console.WriteLine("Player, what is your name?");
            Player1.name = Console.ReadLine();
            RunRound();
        }

       
        private void DetermineRoundWinner()
        {
            double Outcome = Convert.ToInt32((5 + Player1.choice - Player2.choice) % 5);

            if (Outcome == 1 || Outcome == 3)

            {
                Console.WriteLine(Player1.name + ", you win the round!!!");
                Console.ReadLine();
                AddToScore(Player1);
                DetermineGameWinner();

            }

            else if (Outcome == 2 || Outcome == 4)

            {
                Console.WriteLine(Player2.name + " has won the round!!!");
                Console.ReadLine();
                AddToScore(Player2);
                DetermineGameWinner();
            }


            else if (Outcome == 0)

            {

                Console.WriteLine("There has been a tie! This round didn't count.");
                Console.ReadLine();
                RunRound();

            }

        }

        private void DetermineGameWinner()
        {
            if (Player1.score == 3)

            {
                Console.WriteLine("Congratulations " + Player1.name + ", you have won the game!!!");
                Console.ReadLine();
                Console.Clear();
                RunPreliminaries();
                
            }
            else if (Player2.score == 3)
            {
                Console.WriteLine(Player2.name + " has won the game!!!");
                Console.ReadLine();
                Console.Clear();
                RunPreliminaries();
                
            }
            else
            {
                Console.WriteLine("On to the next round!");
                Console.ReadLine();
                RunRound();
            }
        }
    }
}

