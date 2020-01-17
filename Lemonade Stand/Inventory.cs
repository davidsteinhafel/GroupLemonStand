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
            cups = new List<Cup>();
            lemons = new List<Lemon>();
            sugarcubes = new List<SugarCube>();
            icecubes = new List<IceCube>();




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

