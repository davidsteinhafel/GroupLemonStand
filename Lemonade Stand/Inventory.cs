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
<<<<<<< HEAD
            cups = new List<Cup>();
            lemons = new List<Lemon>();
            sugarcubes = new List<SugarCube>();
            icecubes = new List<IceCube>();

=======
            lemons = new List<Lemon>();
            icecubes = new List<IceCube>();
            sugarcubes = new List<SugarCube>();
            cups = new List<Cup>();
>>>>>>> 61bf75abf91a3278cf03ee55940d4ffdc97fe0e1



        }

        //methods
        public void AddLemons(int numberOfLemons)
        {
            for(int i = 0; i < numberOfLemons; i++)
            {
                lemons.Add(new Lemon());
            }
        }

        public void AddCups(int numberOfCups)
        {
            for (int i = 0; i >= numberOfCups;i++)
            {
                cups.Add(new Cup());
            }
        }

        public void AddIceCubes(int numerOfIceCubes)
        {
            for (int i = 0; i >= numerOfIceCubes; i++) 
            {
                icecubes.Add(new IceCube());
            }
        }

        public void AddSugarCubes(int numberOfsugarCubes)
        {
            for (int i = 0; i >= numberOfsugarCubes; i++)
            {
                sugarcubes.Add(new SugarCube());
            }
        }
       

        
    }
    //dispaly methods console.writeline
}

