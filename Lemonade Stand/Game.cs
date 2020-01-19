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
        public List<Day> days;
        public int currentDay;
        public Player player1;
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

            while(!gameover())
            {
             //money and current day work but temp still needs work!
             //UserInterface.DisplayCurrentMoney(new Wallet());
               //UserInterface.CurrentTemp(new List<int>());
              //UserInterface.DisplayCurrentDay(new Day());
               store.InventoryAquisition(player1);
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
                    }
                    else
                    {
                        Console.WriteLine("No sale");
                    }

                }
                weather.Forcasting();
            }
        }

        public bool gameover()
        { 
            if (player1.wallet1.Money == 0)
            {
                Console.WriteLine("gameover");
                return true;
               
            }
            else if (day.days== day.maxdays)
            {
                Console.WriteLine("you survived");
                return true;
            }
            else
            {
                return false;
            }
                
                    

        }
    }
}//method for win lose conditions

