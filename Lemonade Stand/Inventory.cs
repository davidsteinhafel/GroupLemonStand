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

        //public List(Lemon)

        //constructor
        public Inventory()
        {
            cups = new List<Cup>();
            lemons = new List<Lemon>();
            sugarcubes = new List<SugarCube>();
            icecubes = new List<IceCube>();
                


        }

        //methods

    }
}
