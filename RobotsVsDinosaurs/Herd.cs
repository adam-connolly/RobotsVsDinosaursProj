using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Herd
    {
        public Dinosaur trex;
        public Dinosaur pterodactyl;
        public Dinosaur velociraptor;
        public List<Dinosaur> dinoList = new List<Dinosaur>();

        public Herd()
        {
            trex = new Dinosaur("T-Rex", 125, 3, 50, 51);
            pterodactyl = new Dinosaur("Pterodactyl", 100, 5, 4, 7);
            velociraptor = new Dinosaur("Velociraptor", 75, 8, 6, 9);           
            dinoList.Add(trex);
            dinoList.Add(pterodactyl);
            dinoList.Add(velociraptor);
        }
        public void DisplayHerd()
        {
            Console.WriteLine("Dinosaur Herd");
            for (int i = 0; i < dinoList.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + dinoList[i].type + " " + dinoList[i].health + " HP, " + dinoList[i].attackPower + " Attack Power\n");

            }
            
        }
    }

}
