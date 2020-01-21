using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Inventory
    {
        public List<Lemon> lemons;
        public List<IceCube> icecubes;
        public List<SugarCube> sugarcubes;
        public List<Cup> cups;
        public Inventory()
        {
            cups = new List<Cup>();
            lemons = new List<Lemon>();
            sugarcubes = new List<SugarCube>();
            icecubes = new List<IceCube>();
        }
        public void AddLemons(double numberOfLemons)
        {
            for(int i = 0; i < numberOfLemons; i++)
            {
                lemons.Add(new Lemon());
            }
        }
        public void AddCups(double numberOfCups)
        {
            for (int i = 0; i < numberOfCups;i++)
            {
                cups.Add(new Cup());
            }
        }
        public void AddIceCubes(double  numerOfIceCubes)
        {
            for (int i = 0; i < numerOfIceCubes; i++) 
            {
                icecubes.Add(new IceCube());
            }
        }
        public void AddSugarCubes(double numberOfsugarCubes)
        {
            for (int i = 0; i < numberOfsugarCubes; i++)
            {
                sugarcubes.Add(new SugarCube());
            }
        }
        
    }
}

