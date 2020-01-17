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
        public static void DisplayCurrentMoney(Wallet Money)
        {
            Console.WriteLine("Current money made is {0}", Money.Money);
        }
        public static void CurrentTemp(List<int> temperature)
        {
            Console.WriteLine("Current temperature is {0}", temperature);
        }
        public static string UserInput(string choice)
        {
            choice = Console.ReadLine();
            return choice;
        }
        public static void SetName(Player name)
        {
            Console.WriteLine("What is your name?");
            UserInput(name.name);
        }


        //Display Current Day, Current Money made that day, Current temp, Weather forcast, update amount left of cups,lemons,ice,sugar
    }


}
