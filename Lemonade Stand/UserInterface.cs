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
            Console.WriteLine("Current day is {0}", day.days);
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
        public static void DisplayRemainingInventory(Inventory inventory1)
        {
            Console.WriteLine("{0} left, {1} left, {2} left, {3} left,", inventory1.cups, inventory1.lemons, inventory1.icecubes, inventory1.sugarcubes);
        }
        public static void DisplayCurrentMoney(Wallet wallet)
        {
            Console.WriteLine("You currently have {0} much money", wallet.Money);
        }
    }
    //Display Current Day, Current Money made that day, Current temp, Weather forcast, update amount left of cups,lemons,ice,sugar
}



