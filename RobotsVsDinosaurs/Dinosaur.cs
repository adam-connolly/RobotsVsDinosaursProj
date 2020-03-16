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
        public int attack;
        public int attackPower;

        public Dinosaur(string type, int health, int energy, int i, int j)
        {
            this.type = type;
            this.health = health;
            this.energy = energy;
            attack = power.Next(i,j);
            attackPower = attack * 4;
        }

        //public void DisplayStats(Dinosaur dino)
        //{
        //    Console.WriteLine(this.type);
        //    Console.WriteLine(health);
        //    Console.WriteLine(energy);
        //    Console.WriteLine(attackPower);
        //}
    }
}
