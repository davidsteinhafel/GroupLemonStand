
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

            //customerChoice = random.Next(11);
            //customerBuy = false;
            
           
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

        public void CustomerBuyLemon(Day day,Player player1)
        {
            foreach (Customer customer in day.customers)

                if (customer.DesicionToBuy(day.weather, player1.recipe) == true)
                {
                    UserInterface.MakeSale(player1, player1.wallet1, player1.pitcher1);
                }

        }
        //public void AddCustomer(Day day, Player player1)
        //{
        //    for (int i = 0; i < day.CustomerCount; i++)
        //    {
        //        day.customers.Add(new Customer());
        //        day.customer.DesicionToBuy(day.weather, player1.recipe);
        //    }
        //}


    }
}
