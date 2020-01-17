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




        
        public Recipe()
        {
            amountOfIceCubes = 0;
            amountOfLemons = 0;
            amountOfSugarCubes = 0;
            pricePerCup = 0; //dynamic;
        }
        public void SetRecipe()
        {
            bool isValid = false;
            do
            {
                Console.WriteLine("How many Ice Cubes do you want to use");
                isValid = int.TryParse(Console.ReadLine(), out amountOfIceCubes);
            } while (isValid == false);
            do
            {
                Console.WriteLine("How many Lemons do you want to use");
                isValid = int.TryParse(Console.ReadLine(), out amountOfLemons);
            } while (isValid == false);
            do
            {
                Console.WriteLine("How many Sugar Cubes do you want to use");
                isValid = int.TryParse(Console.ReadLine(), out amountOfSugarCubes);
            } while (isValid == false); 
            //Recipe userRecipe = new Recipe(amountOfLemons, amountOfIceCubes, amountOfSugarCubes);
        }
        public void setPricePerCup()   
        {
            bool isValid = false;
            do
            {
                Console.WriteLine("Set Price Per Cup");
                isValid = double.TryParse(Console.ReadLine(), out pricePerCup);
            } while (isValid == false);
        }
    }
}
