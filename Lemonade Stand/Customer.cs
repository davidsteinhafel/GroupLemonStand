
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

        public Customer(Random random)
        {
            this.random = random;
            name = "customer";
        }
        public bool DesicionToBuy(Weather weather, Recipe recipe)
        {
            if (recipe.pricePerCup > 5)
            {
                return false;
            }
            int numBasedOnRecipe;
            int numBaseOnWeather;
            if ((recipe.amountOfLemons < 1 || recipe.amountOfLemons > 7) || (recipe.amountOfSugarCubes < 2 || recipe.amountOfSugarCubes > 20))
            {
                numBasedOnRecipe = random.Next(0, 100);
            }
            else
            {
                numBasedOnRecipe = random.Next(50, 100);
            }
            if (weather.temperature < 60 || weather.name != "sunny" || weather.name != "cloudy")
            {
                numBaseOnWeather = random.Next(0, 100);
            }
            else
            {
                numBaseOnWeather = random.Next(50, 100);
            }
            if (numBaseOnWeather >= 60 && numBasedOnRecipe >= 60)
            {
                Console.WriteLine("Sale!");
                return true;
            }
            else
            {
                Console.WriteLine("No Sale!");
                return false;
            }
        }
        public void CustomerBuyLemon(Day day, Player player1)
        {
            foreach (Customer customer in day.customers)

                if (customer.DesicionToBuy(day.weather, player1.recipe) == true)
                {
                    UserInterface.MakeSale(player1);
                }
        }
    }
}
