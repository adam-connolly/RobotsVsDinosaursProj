using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Dinosaur
    {
        public string type;
        public int health;
        public int energy;
        public Random power = new Random();
        public int attackPower;

        public Dinosaur(string type, int health, int energy)
        {
            this.type = type;
            this.health = health;
            this.energy = energy;
            attackPower = power.Next(2,5);
        }

        //public void DisplayStats(Dinosaur dino)
        //{
        //    Console.WriteLine(this.type);
        //    Console.WriteLine(health);
        //    Console.WriteLine(energy);
        //    Console.WriteLine(attackPower);
        }
    }
}
