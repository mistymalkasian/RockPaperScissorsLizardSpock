﻿using System;
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
            Game NewGame = new Game();
            Player Player = new Player();

            NewGame.Rules();
            NewGame.RunGame();
        }
    }
}
