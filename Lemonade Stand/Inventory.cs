using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Inventory
    {
        //Member Variables
        public List<Lemon> lemons;
        public List<IceCube> icecubes;
        public List<SugarCube> sugarcubes;
        public List<Cup> cups;

        //public List(Lemon)

        //constructor
        public Inventory()
        {
            lemons = new List<Lemon>();
            icecubes = new List<IceCube>();
            sugarcubes = new List<SugarCube>();
            cups = new List<Cup>();



        }

        //methods
    }
}
