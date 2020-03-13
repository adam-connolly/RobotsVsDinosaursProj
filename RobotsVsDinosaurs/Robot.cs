using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Robot
    {
        public string name;
        public int health;
        public Random power = new Random();
        public Weapon weapon;
        public int powerLevel;

        public Robot(string name)
        {
            this.name = name;
            health = 100;
            weapon = new Weapon();
            powerLevel = power.Next(1, 10);            
        }
    }
}
