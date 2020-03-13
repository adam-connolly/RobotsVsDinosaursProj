using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Herd
    {
        public Dinosaur dino1;
        public Dinosaur dino2;
        public Dinosaur dino3;
        public List<Dinosaur> dinoList = new List<Dinosaur>();

        public Herd()
        {
            dino1 = new Dinosaur("Velociraptor", 75, 8);
            dino2 = new Dinosaur("T-Rex", 125, 3);
            dino3 = new Dinosaur("Pterodactyl", 100, 5);
            dinoList.Add(dino1);
            dinoList.Add(dino2);
            dinoList.Add(dino3);
        }
        //public void DisplayHerd()
        //{
        //    foreach(Dinosaur dino in dinoList)
        //    {
        //        Console.WriteLine(dino.DisplayStats(dino));
        //    }

        //}
    }

}
