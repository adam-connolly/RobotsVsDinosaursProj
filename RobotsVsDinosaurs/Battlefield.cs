using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Battlefield
    {
        public Herd herd;
        public Fleet fleet;
        public Battlefield()
        {
            herd = new Herd();
            fleet = new Fleet();
        }

        //public void DisplayCombatants()
        //{
        //    Console.WriteLine(DisplayHerd);
        //    Console.WriteLine(DisplayFleet);
        //}
    }
}
