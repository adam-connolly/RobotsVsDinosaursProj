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
        public Robot robotAttacker;
        public Dinosaur dinoAttacker;
        public Battlefield()
        {
            herd = new Herd();
            fleet = new Fleet();
        }

        public void DisplayCombatants()
        {
            herd.DisplayHerd();
            fleet.DisplayFleet();            
        }

        public Robot ChooseRobotAttacker()
        {
            Console.WriteLine("Choose who you want to attack with:\n1. Jarvis\n2. RoboCop\n3. Cortana");
            int input = Convert.ToInt32(Console.ReadLine());
            robotAttacker = fleet.robotList[input - 1];
            return robotAttacker;
        }
        public Dinosaur ChooseDinoAttacker()
        {
            Console.WriteLine("Choose who you want to attack with:\n1. T-Rex\n2. Pterodactyl\n3. Velociraptor");
            int input = Convert.ToInt32(Console.ReadLine());
            dinoAttacker = herd.dinoList[input - 1];
            return dinoAttacker;
        }

        public void AttackFleet(Dinosaur dino)
        {
            Console.WriteLine($"Choose an enemy to attack:\n1. Jarvis {fleet.jarvis.health} HP\n2. RoboCop {fleet.roboCop.health} HP\n3. Cortana {fleet.cortana.health} HP");
            int input = Convert.ToInt32(Console.ReadLine());
            
            Robot robot = fleet.robotList[input - 1];
            
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
        public void AttackHerd(Robot robot)
        {
            Console.WriteLine($"Choose an enemy to attack:\n1. T-Rex {herd.trex.health} HP\n2. Pterodactyl {herd.pterodactyl.health} HP\n3. Velociraptor {herd.velociraptor.health} HP");
            int input = Convert.ToInt32(Console.ReadLine());
            Dinosaur dino = herd.dinoList[input - 1];
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
