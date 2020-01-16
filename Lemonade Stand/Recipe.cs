using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Recipe
    {
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;

        

        public Recipe()
        {
            amountOfLemons = 4;
            amountOfIceCubes = 4;
            amountOfSugarCubes = 4;
            pricePerCup = .25;

            this.amountOfIceCubes = amountOfIceCubes;
            this.amountOfLemons = amountOfLemons;
            this.amountOfSugarCubes = amountOfSugarCubes;
            this.pricePerCup = pricePerCup;

            new Pitcher pitcher1();
            //Constructor
        }
        public void MakeLemonade()
        {
            amountOfSugarCubes + amountOfLemons + amountOfIceCubes = new Pitcher();
            //lemons + sugar + iceCube 
            //4lemon + 4cups + 4 ice cub
        }
    }
}
