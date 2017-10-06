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

        string name1;
        string name2;
        public double Player1Choice;
        public double Player2Choice;

        Player Player1 = new Player();
        Player Player2 = new Player();
        CPU CPU = new CPU();


        //object constructor

        //member methods



        public void StartGame()
        {
            Console.WriteLine("");
            Console.WriteLine("=========================");
            Console.WriteLine("=================");
            Console.WriteLine("========");
            Console.WriteLine("==");
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
            Console.WriteLine("==");
            Console.WriteLine("========");
            Console.WriteLine("=================");
            Console.WriteLine("=========================");
            Console.WriteLine("");
            Console.WriteLine("Please press ENTER to continue.");
            Console.ReadLine();
            DecideOpponent();

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
                    Console.WriteLine(name1 + ", you chose rock!");
                    Console.ReadLine();
                    Console.Clear();

                    break;

                case 2:
                    Console.WriteLine(name1 + ", you chose paper!");
                    Console.ReadLine();
                    Console.Clear();

                    break;

                case 3:
                    Console.WriteLine(name1 + ", you chose scissors!");
                    Console.ReadLine();
                    Console.Clear();

                    break;

                case 4:
                    Console.WriteLine(name1 + ", you chose lizard!");
                    Console.ReadLine();
                    Console.Clear();

                    break;

                case 5:
                    Console.WriteLine(name1 + ", you chose Spock!");
                    Console.ReadLine();
                    Console.Clear();

                    break;

                default:

                    Console.WriteLine("You have made an invalid selection. Please only choose an integral number between 1 and 5.");
                    Console.Clear();
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
                    Console.WriteLine(name2 + ", you chose rock!");
                    Console.ReadLine();
                    Console.Clear();

                    break;

                case 2:
                    Console.WriteLine(name2 + ", you chose paper!");
                    Console.ReadLine();
                    Console.Clear();

                    break;

                case 3:
                    Console.WriteLine(name2 + ", you chose scissors!");
                    Console.ReadLine();
                    Console.Clear();

                    break;

                case 4:
                    Console.WriteLine(name2 + ", you chose lizard!");
                    Console.ReadLine();
                    Console.Clear();

                    break;

                case 5:
                    Console.WriteLine(name2 + ", you chose Spock!");
                    Console.ReadLine();
                    Console.Clear();

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

            name1 =Console.ReadLine();


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
                    Console.WriteLine(name1 + ", you chose rock!");
                    Console.ReadLine();


                    break;

                case 2:
                    Console.WriteLine(name1 + ", you chose paper!");
                    Console.ReadLine();

                    break;

                case 3:
                    Console.WriteLine(name1 + ", you chose scissors!");
                    Console.ReadLine();

                    break;

                case 4:
                    Console.WriteLine(name1 + ", you chose lizard!");
                    Console.ReadLine();

                    break;

                case 5:
                    Console.WriteLine(name1 + ", you chose Spock!");
                    Console.ReadLine();

                    break;

                default:

                    Console.WriteLine("You have made an invalid selection. Please only choose an integral number between 1 and 5.");
                    Console.Clear();
                    RunPvCGame();

                    break;
            }

            Console.WriteLine("The Computer has chosen as well!");

            Random Random = new Random();
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
            Console.ReadLine();
            DetermineRoundWinner();
        }


        private void DetermineRoundWinner()
        {
            double d = Convert.ToInt32((5 + Player1Choice - Player2Choice) % 5);


            if (d == 1 | d == 3)

            {
                Console.WriteLine(name1 + ", you win!!!");
                Console.ReadLine();
                Console.ReadLine();
                AddToScore1();
            }



            else if (d == 2 | d == 4)

            {

                Console.WriteLine(name2 + " has won!!!");
                Console.ReadLine();
                AddToScore2();
            }


            else

            { 
                
            Console.WriteLine("There has been a tie!");
            Console.ReadLine();

            }
        }


        private void DetermineGameWinner()
        {
            if (Player1.score == 2)
               
            {
                Console.WriteLine("Congratulations " + name1 + ", you have won the game!!!");
            }
            else 
            {
                Console.WriteLine("No winner has been determined yet! On to the next round!");
                DetermineRoundWinner();

            }

        }

        private double AddToScore1()
        {
            double AddedScore = Player1.score + 1;
            return AddedScore;
        }

        private double AddToScore2()
        {
            double AddedScore = Player1.score + 1;
            return AddedScore;
        }

    }
}

