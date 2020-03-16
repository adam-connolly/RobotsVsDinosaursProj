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
        public int attackPower;

        public Robot(string name, int health, int i, int j)
        {
            this.name = name;
            this.health = health;
            weapon = new Weapon();
            powerLevel = power.Next(i, j);
            attackPower = powerLevel * weapon.weaponDamage;
        }
        public void DisplayStats()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Healt: {health}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Weapon: {weapon}");
        }
    }
}
