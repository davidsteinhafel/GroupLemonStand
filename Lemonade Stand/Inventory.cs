using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Inventory
    {
        //Member Variables
        public int lemons;
        public int icecube;
        public int sugarcubes;
        public int cups;

        //constructor
        public Inventory(int lemons,int icecubes, int sugarcubes,int cups)
        {
            this.cups = cups;
            this.lemons = lemons;
            this.sugarcubes = sugarcubes;
            this.icecube = icecubes;
                


        }

        //methods
    }
}
