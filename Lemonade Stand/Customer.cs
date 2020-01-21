
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Customer
    {
        public string name;
        Random random;
        int customerChoice;
        bool customerBuy;
        
        public Customer()
        {
            random = new Random();

            name = "customer";

            customerChoice = random.Next(11);
            customerBuy = false;
           
        }


        public bool DesicionToBuy(Weather weather, Recipe recipe)
        {
            if (recipe.pricePerCup > 5)
            {
                return false;
            }
            int numBasedOnRecipe;
            int numBaseOnWeather;
            if((recipe.amountOfLemons < 1 || recipe.amountOfLemons > 7) || (recipe.amountOfSugarCubes < 2 || recipe.amountOfSugarCubes > 20))
            {
                numBasedOnRecipe = random.Next(0, 100);
            }
            else
            {
                numBasedOnRecipe = random.Next(50, 100);
            }
            if(weather.temperature < 60 || weather.weather != "sunny"|| weather.weather != "cloudy")
            {
                numBaseOnWeather = random.Next(0, 100);
            }else
            {
                numBaseOnWeather = random.Next(50, 100);
            }
            if (numBaseOnWeather >= 60 && numBasedOnRecipe >= 60)
            {
                Console.WriteLine("Sale made");
                return true;

            }
            else
            {
                Console.WriteLine("No sale");
                return false;
            }

           
        }


    }
}
