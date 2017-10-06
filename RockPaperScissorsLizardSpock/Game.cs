using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {
        //member variables

        //object constructor

        //member methods

        Random Random = new Random();

        private void DisplayRules()
        {
            Console.WriteLine("You are playing \"Rock Paper Scissors Lizard Spock\"");
            Console.WriteLine("These are the rules: ");
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock");
            Console.WriteLine("and (as it always has,) Rock crushes Scissors");
            Console.WriteLine("Please press ENTER to continue.");
            Console.ReadLine();

        }

        private void DecideOpponent()

        {
            Console.WriteLine("Will you be playing against another player? Type 1 if yes, 2 if no.");
            int PlayerAnswer = Convert.ToInt32(Console.ReadLine());

            switch (PlayerAnswer)
            {
                case 1:
                    RunPvPGame();
                    break;

                case 2:
                    RunPvCGame();
                    break;

                default:
                    Console.WriteLine("You have made an invalid selection. Please only choose either 1 or 2.");
                    Console.ReadLine();
                    DecideOpponent();
                    break;

            }
        }

        private void RunPvPGame()
        {
            Console.WriteLine("Player1, what is your name?");
            string name1 = Console.ReadLine();
            Console.WriteLine("Player 2, what is your name?");
            string name2 = Console.ReadLine();


            Console.WriteLine(name1 + ", please make your selection.");
            Console.WriteLine("Choose 1 for Rock.");
            Console.WriteLine("Choose 2 for Paper.");
            Console.WriteLine("Choose 3 for Scissors.");
            Console.WriteLine("Choose 4 for Lizard.");
            Console.WriteLine("Choose 5 for Spock.");

            int UserChoice1 = Convert.ToInt32(Console.ReadLine());

            switch (UserChoice1)
            {

                case 1:

                    break;

                case 2:

                    break;

                case 3:

                    break;

                case 4:

                    break;

                case 5:

                    break;

                default:

                    Console.WriteLine("You have made an invalid selection. Please only choose an integral number between 1 and 5.");
                    RunPvPGame();

                    break;
            }


            Console.WriteLine(name2 + ", please make your selection.");
            Console.WriteLine("Choose 1 for Rock.");
            Console.WriteLine("Choose 2 for Paper.");
            Console.WriteLine("Choose 3 for Scissors.");
            Console.WriteLine("Choose 4 for Lizard.");
            Console.WriteLine("Choose 5 for Spock.");

            int UserChoice2 = Convert.ToInt32(Console.ReadLine());

            switch (UserChoice2)
            {

                case 1:

                    break;

                case 2:

                    break;

                case 3:

                    break;

                case 4:

                    break;

                case 5:

                    break;

                default:

                    Console.WriteLine("You have made an invalid selection. Please only choose an integral number between 1 and 5.");
                    RunPvPGame();

                    break;
            }
        }

        private void RunPvCGame()

        {
            Console.WriteLine("Very well, you may play against the Computer! The Computer is very excited to begin.");

            Console.WriteLine("Player1, what is your name?");
            string name1 = Console.ReadLine();

            Console.WriteLine(name1 + ", please make your selection.");
            Console.WriteLine("Choose 1 for Rock.");
            Console.WriteLine("Choose 2 for Paper.");
            Console.WriteLine("Choose 3 for Scissors.");
            Console.WriteLine("Choose 4 for Lizard.");
            Console.WriteLine("Choose 5 for Spock.");

            int UserChoice1 = Convert.ToInt32(Console.ReadLine());

            switch (UserChoice1)
            {

                case 1:

                    break;

                case 2:

                    break;

                case 3:

                    break;

                case 4:

                    break;

                case 5:

                    break;

                default:

                    Console.WriteLine("You have made an invalid selection. Please only choose an integral number between 1 and 5.");
                    RunPvPGame();

                    break;
            }

            Console.WriteLine("The Computer has chosen as well!");

            int CPUchoice = Random.Next(1, 6);


            switch (CPUchoice)
            {

                case 1:
                    Console.WriteLine("The Computer has chosen rock!");
                    break;

                case 2:
                    Console.WriteLine("The Computer has chosen paper!");
                    break;

                case 3:
                    Console.WriteLine("The Computer has chosen scissors!");
                    break;

                case 4:
                    Console.WriteLine("The Computer has chosen lizard!");
                    break;

                case 5:
                    Console.WriteLine("The Computer has chosen Spock!");
                    break;


            }


        }


    }
}

