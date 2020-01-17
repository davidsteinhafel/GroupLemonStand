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
        public List<Lemon> lemons;
        public List<IceCube>icecubes;
        public List<SugarCube>sugarcubes;
        public List<Cup> cups;

        //constructor
        public Inventory(List<Lemon> lemons, List<IceCube> icecubes, List<SugarCube> sugarcubes, List<Cup> cups)
        {
            this.cups = cups;
            this.lemons = lemons;
            this.sugarcubes = sugarcubes;
            this.icecubes = icecubes;
                


        }

        //methods
    }
}
