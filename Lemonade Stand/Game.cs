using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Game
    {
        List<Day> days;
        int currentDay;
        public Player player;
        Store store;

        public Game()
        {
           
            player = new Player();
            store = new Store();

        }

        public void Start()
        {
            DisplayWelcome();
            DisplayInstructions();
            store.InventoryAquisition(player.wallet,player.inventory);
        }

        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to Lemonade Stand Game!!!");
            Console.ReadLine();
        }
        public void DisplayInstructions()
        {
            Console.WriteLine("Your goal is to make as much money as you can in 7days by selling lemonade. Buy cups, lemons, sugar and ice cubes then set your recipe based on weather conditions. Lastly, set price and sell your lemonade!!!");
        }
        public void AddPlayer()
        {
            player.SetName();
        }
    }
}
