using System;
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
            battlefield.DisplayCombatants();
            battlefield.AttackFleet(battlefield.herd.trex);
            battlefield.AttackHerd(battlefield.fleet.cortana);

            //while (battlefield.herd.dinoList.Count > 0 || battlefield.fleet.robotList.Count > 0)
            //{

            //}

        }

    }

}
