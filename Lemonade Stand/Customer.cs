
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Customer
    {

        Random random;
        int customerChoice;
        bool customerBuy;

        public Customer()
        {
            random = new Random();
            
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
                return true;
            }
            else
            {
                return false;
            }

            //if(rng > 60)
            //{
            //    customerBuy = true;
            //}
            //else if(weather.temperature > 90)
            //{
            //    rng += 45;
            //}
            //else if(weather.temperature > 60 && weather.temperature < 90)
            //{
            //    rng += 30;
            //}
            //else if (weather.temperature > 30 && weather.temperature < 60)
            //{
            //    rng += 15;
            //}
            //else if (weather.temperature > -10 && weather.temperature < 30)
            //{
            //   rng -= 15;
            //}
            //else if(recipe.amountOfLemons < 4)
            //{
            //    rng -= 15;
            //}
            //else if(recipe.amountOfSugarCubes < 4)
            //{
            //    rng -= 15;
            //}
            //else if(recipe.amountOfIceCubes < 4)
            //{
            //    rng -= 15;
            //}
        }

    }
}
