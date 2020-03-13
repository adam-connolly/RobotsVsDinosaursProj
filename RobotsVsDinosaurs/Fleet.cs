using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Fleet
    {
        public Robot robot1;
        public Robot robot2;
        public Robot robot3;

        public Fleet()
        {
            robot1 = new Robot("Robot 1");
            robot2 = new Robot("Robot 2");
            robot3 = new Robot("Robot 3");
        }

    }
}
