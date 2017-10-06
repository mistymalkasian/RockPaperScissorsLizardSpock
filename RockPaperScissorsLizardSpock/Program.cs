using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Program
    {
        static void Main(string[] args)
        {
            Game Game = new Game();
            Player Player = new Player();
            HumanPlayer HumanPlayer = new HumanPlayer();
            CPU CPU = new CPU();


            Game.DisplayRules();
           


        }
    }
}
