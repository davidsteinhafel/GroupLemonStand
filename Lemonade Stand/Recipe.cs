using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Recipe
    {
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;




        
        public Recipe(int amountOfLemons, int amountOfIceCubes, int amountOfSugarCubes)
        {


            this.amountOfIceCubes = amountOfIceCubes;
            this.amountOfLemons = amountOfLemons;
            this.amountOfSugarCubes = amountOfSugarCubes;
            pricePerCup = .25;


            //Constructor
        }
        
    }
}
