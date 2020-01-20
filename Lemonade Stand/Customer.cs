
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
        public List<int> customerPreference;
        int customerChoice;
        bool customerBuy;

        public Customer()
        {
            random = new Random();
            customerPreference = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            customerChoice = random.Next(11);
            customerBuy = false;
        }
        public void DesicionToBuy(Weather weather, Recipe recipe)
        {
            int rng;
            rng = random.Next(1, 100);
            

            if(rng > 60)
            {
                customerBuy = true;
            }
            else if(weather.temperature > 90)
            {
                rng += 45;
            }
            else if(weather.temperature > 60 && weather.temperature < 90)
            {
                rng += 30;
            }
            else if (weather.temperature > 30 && weather.temperature < 60)
            {
                rng += 15;
            }
            else if (weather.temperature > -10 && weather.temperature < 30)
            {
               rng -= 15;
            }
            else if(recipe.amountOfLemons < 4)
            {
                rng -= 15;
            }
            else if(recipe.amountOfSugarCubes < 4)
            {
                rng -= 15;
            }
            else if(recipe.amountOfIceCubes < 4)
            {
                rng -= 15;
            }
        }

    }
}
