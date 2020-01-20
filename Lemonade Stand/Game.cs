using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Game
    {
        Day day;
        Player player1;
        Store store;
        Weather weather;
        Random random;
        Customer customer;
        Recipe recipe;
        public Game()
        {
            store = new Store();
            player1 = new Player();
            random = new Random();
            customer = new Customer();
            day = new Day();
        }
        public void Start()
        {
            UserInterface.DisplayWelcome();
            UserInterface.DisplayInstructions();
            UserInterface.SetName();
            store.InventoryAquisition(player1);






            //UserInterface.DisplayCurrentMoney(player1.wallet1);
            //UserInterface.CurrentTemp(weather);
            //UserInterface.DisplayCurrentDay(day);
            
            recipe.SetRecipe();
            recipe.setPricePerCup();
            weather.Weathercontrol();
            weather.Tempcontrol();


            int rgn = random.Next(2, 10);
            for (int i = 0; i < rgn; i++)
            {
                double potentialcustomer = customer.CustomerPreference(weather);
                if (recipe.pricePerCup <= potentialcustomer)
                {
                    Console.WriteLine("Sale");
                    player1.wallet1.Money += recipe.pricePerCup;
                }
                else
                {
                    Console.WriteLine("No sale");
                }
            }
            weather.Forcasting();

        }

        public void gameover()
        {
            if (player1.wallet1.Money == 0 && UserInterface.CalculateDepletedInventory(player1.inventory1) == true)
            {
                Console.WriteLine("gameover");
            }

        }
    }
}

