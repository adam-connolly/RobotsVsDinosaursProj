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

        public int AttackFleet(Dinosaur dino, Robot robot)
        {
            int newHealth = robot.health - dino.attackPower;
            if(newHealth == 0)
            {
                Console.WriteLine($"You have destroyed {robot.name}!");
                robot.health = newHealth;
                return robot.health;
            }
            else
            {
                Console.WriteLine($"{robot.name} has {newHealth} health remaining!");
                robot.health = newHealth;
                return robot.health;
            }
        }
    }
}
