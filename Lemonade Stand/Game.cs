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
        List<Day> days;
        int currentday;
        Player player1;
        Store store;
        Weather weather;
        Customer customer;
        Recipe recipe;
        Random random;

        public Game()
        {
            store = new Store();
            player1 = new Player();
            random = new Random();
            days = new List<Day>();
            currentday = 0;

        }
        public void Start()
        {
            UserInterface.DisplayWelcome();
            UserInterface.DisplayInstructions();
            UserInterface.SetName();
            store.InventoryAquisition(player1);



            while (gameover())
            {
               
                store.InventoryAquisition(player1);
                recipe.SetRecipe();
                recipe.setPricePerCup();
                day.displaystartofdaybalance(player1.wallet1);
                day.displaydailyprofits(player1.wallet1);
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
            }
            
        }
        public bool gameover()
        {
            
            if (player1.wallet1.Money == 0 && UserInterface.CalculateDepletedInventory(player1.inventory1) == true)
            {
                Console.WriteLine("gameover");
                return true;
            }
          else
          {
                return false;
          }

        }

       
    }
}

