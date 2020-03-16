﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Game
    {
        public Battlefield battlefield;

        public Game()
        {
            battlefield = new Battlefield();
        }
        public void RunGame()
        {
            do
            {
                battlefield.DisplayCombatants();

                if (battlefield.herd.dinoList.Count > 0 && battlefield.fleet.robotList.Count == 0)
                {
                    Console.WriteLine("Dinosaurs Win!!");
                }
                else if (battlefield.herd.dinoList.Count == 0 && battlefield.fleet.robotList.Count > 0)
                {
                    Console.WriteLine("Robots Win!!");
                }
                else
                {
                    battlefield.AttackFleet(battlefield.ChooseDinoAttacker());
                    battlefield.AttackHerd(battlefield.ChooseRobotAttacker());
                }
            }
            while (battlefield.herd.dinoList.Count > 0 && battlefield.fleet.robotList.Count > 0);
        }

    }

}
