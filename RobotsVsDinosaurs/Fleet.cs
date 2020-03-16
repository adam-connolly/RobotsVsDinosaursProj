using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Fleet
    {
        public Robot jarvis;
        public Robot roboCop;
        public Robot cortana;
        public List<Robot> robotList = new List<Robot>();
        public Fleet()
        {
            jarvis= new Robot("Jarvis", 125 , 2, 5);
            roboCop = new Robot("RoboCop", 100, 4, 7);
            cortana = new Robot("Cortana", 75, 6, 9);
            robotList.Add(jarvis);
            robotList.Add(roboCop);
            robotList.Add(cortana);
        }
        public void DisplayFleet()
        {
            Console.WriteLine("Robot Fleet");
            for (int i = 0; i < robotList.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + robotList[i].name + " " + robotList[i].health + " HP, " + robotList[i].attackPower + " Attack Power\n");
            }
            
        }
    }
}
