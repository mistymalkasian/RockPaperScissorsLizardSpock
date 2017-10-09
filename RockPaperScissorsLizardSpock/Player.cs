﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Player
    {
        //member variables

       public double score;
       public double choice;
       public string name;

        //object constructor

        public Player()
        {
            score = 0;
            
        }
        //member methods

        public virtual void PlayerChoose(Player player)
        {
            Console.WriteLine(name + ", please make your selection.");
            Console.WriteLine("Choose 1 for rock.");
            Console.WriteLine("Choose 2 for paper.");
            Console.WriteLine("Choose 3 for scissors.");
            Console.WriteLine("Choose 4 for Spock.");
            Console.WriteLine("Choose 5 for lizard.");

            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine(name + ", you chose rock!");
                Console.ReadLine();
                Console.Clear();

            }

            else if (choice == 2)
            {
                Console.WriteLine(name + ", you chose paper!");
                Console.ReadLine();
                Console.Clear();
            }

            else if (choice == 3)
            {
                Console.WriteLine(name + ", you chose scissors!");
                Console.ReadLine();
                Console.Clear();
            }

            else if (choice == 4)
            {
                Console.WriteLine(name + ", you chose Spock!");
                Console.ReadLine();
                Console.Clear();
            }

            else if (choice == 5)
            {
                Console.WriteLine(name + ", you chose lizard!");
                Console.ReadLine();
                Console.Clear();
            }


            else
            {
                Console.WriteLine("You have made an invalid selection. Please only choose an integral number between 1 and 5.");

            }

        }

    }
        

    }

