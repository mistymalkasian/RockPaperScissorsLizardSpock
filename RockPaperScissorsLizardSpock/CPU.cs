﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class CPU : Player
    {
       
       

        public CPU()
        {
            name = "The Computer";
            score = 0;

        }


        public override void PlayerChoose(Player player)
        {
            Random Random = new Random();
            choice = Random.Next(1, 6);

            Console.WriteLine(name + " has made a decision as well!");

            if (choice == 1)
            {
                Console.WriteLine(name + " has chosen rock!");
                Console.ReadLine();
                Console.Clear();
            }

            else if (choice == 2)
            {
                Console.WriteLine(name + " has chosen paper!");
                Console.ReadLine();
                Console.Clear();
            }

            else if (choice == 3)
            {
                Console.WriteLine(name + " has chosen scissors!");
                Console.ReadLine();
                Console.Clear();
            }

            else if (choice == 4)
            {
                Console.WriteLine(name + " has chosen Spock!");
                Console.ReadLine();
                Console.Clear();
            }

            else if (choice == 5)
            {
                Console.WriteLine(name + " has chosen lizard!");
                Console.ReadLine();
                Console.Clear();
            }


    }
  }
}
       
 
