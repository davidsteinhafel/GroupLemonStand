using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public static class UserInterface
    {
        public static void DisplayCurrentDay(Day day)
        {
            Console.WriteLine("Current day is {0}", day);
        }
        public static void CurrentTemp(Weather weather)
        {
            Console.WriteLine("Current temperature is {0}", weather.temperature);
        }
        public static string UserInput()
        {
            string choice = Console.ReadLine();
            return choice;
        }
        public static double ChangeToDouble()
        {
            try
            {
                return Convert.ToDouble(UserInput());
            }
            catch (Exception e)
            {
                return ChangeToDouble();
            }
        }
        public static void SetName()
        {
            Console.WriteLine("What is your name?");
            UserInput();
        }
        public static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to Lemonade Stand Game!!!");
        }
        public static void DisplayInstructions()
        {
            Console.WriteLine("Your goal is to make as much money as you can in 7days by selling lemonade. Buy cups, lemons, sugar and ice cubes then set your recipe based on weather conditions. Lastly, set price and sell your lemonade!!!");
        }
        public static void DisplayWeatherForecast(Weather weather)
        {
            Console.WriteLine("Predicted forecast is {0}", weather.predictedForecast);
        }
        public static void DisplayCurrentWeather(Weather weather)
        {
            Console.WriteLine("Current weather is {0}", weather);
        }
        public static void DisplayRemainingInventory(Inventory inventory1)
        {
            Console.WriteLine("{0} cups left, {1} lemons left, {2} ice cubes left, {3} sugar cubes left,", inventory1.cups.Count, inventory1.lemons.Count, inventory1.icecubes.Count, inventory1.sugarcubes.Count);
        }
        public static void DisplayCurrentMoney(Wallet wallet)
        {
            Console.WriteLine("You currently have ${0} left", wallet.Money);
        }
        public static bool CalculateDepletedInventory(Inventory inventory1)
        {
            if (inventory1.cups.Count == 0 && inventory1.icecubes.Count == 0 && inventory1.lemons.Count == 0 && inventory1.sugarcubes.Count == 0)
            {
                Console.WriteLine("Inventory is depleted");
                return true;
            }
            else
            {
                Console.WriteLine("You still have items in your inventory");
                DisplayRemainingInventory(inventory1);
                return false;
            }
        }
        public static void DisplayStartingDayBalance(Wallet wallet)
        {

        }
        public static void MakeSale(Player player)
        {
           player.wallet1.Money += player.recipe.pricePerCup;
           player.pitcher1.CupsinPitcher -= 1;
             Console.WriteLine("SALE!!!");
             Console.ReadLine();
        }
    }

}


