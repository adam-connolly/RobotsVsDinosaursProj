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
            Console.WriteLine($"{jarvis.name}: {jarvis.health} health");
            Console.WriteLine($"{roboCop.name}: {roboCop.health} health");
            Console.WriteLine($"{cortana.name}: {cortana.health} health");
            Console.ReadLine();
        }
    }
}
