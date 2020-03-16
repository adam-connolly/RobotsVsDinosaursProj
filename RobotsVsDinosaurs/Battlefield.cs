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

        public void AttackFleet(Dinosaur dino, Robot robot)
        {
            if (herd.dinoList.Contains(dino))
            {
                int newHealth = robot.health - dino.attackPower;
                if (newHealth <= 0)
                {
                    Console.WriteLine($"You have destroyed {robot.name}!");
                    robot.health = newHealth;
                    fleet.robotList.Remove(robot);
                    
                }
                else
                {
                    Console.WriteLine($"{robot.name} has {newHealth} health remaining!");
                    robot.health = newHealth;
                   
                }
            }
            else
            {
                Console.WriteLine($"{dino.type} can't attack. {dino.type} is alraedy dead!");
            }
            
        }
        public void AttackHerd(Robot robot, Dinosaur dino)
        {
            if (fleet.robotList.Contains(robot))
            {
                int newHealth = dino.health - robot.attackPower;
                if (newHealth <= 0)
                {
                    Console.WriteLine($"You have killed {dino.type}!");
                    dino.health = newHealth;
                    herd.dinoList.Remove(dino);
                    
                }
                else
                {
                    Console.WriteLine($"{dino.type} has {newHealth} health remaining!");
                    dino.health = newHealth;
                    
                }
                
            }
            else
            {
                Console.WriteLine($"{robot.name} can't attack. {robot.name} is already destroyed!");
            }
        }
    }
}
