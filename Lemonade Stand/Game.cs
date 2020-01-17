using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Game
    {
        public List<Day> days;
        public int currentDay;
        public Player player;
<<<<<<< HEAD
        Store store;
        Weather weather;

        public Game()
        {
            
            player = new Player();
=======
        public Store store;

        public Game()
        {
>>>>>>> 61bf75abf91a3278cf03ee55940d4ffdc97fe0e1
            store = new Store();
            player = new Player();
            

        }
        

        public void Start()
        {
<<<<<<< HEAD

            DisplayWelcome();
            DisplayInstructions();
            store.InventoryAquisition(player.wallet1,player.inventory);

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
=======
            UserInterface.DisplayWelcome();
            UserInterface.DisplayInstructions();
            UserInterface.SetName();
            //money and current day work but temp still needs work!
            //UserInterface.DisplayCurrentMoney(new Wallet());
            //UserInterface.CurrentTemp(new List<int>());
            //UserInterface.DisplayCurrentDay(new Day());
            
            store.InventoryAquisition(player.wallet1, player.inventory1);
>>>>>>> 61bf75abf91a3278cf03ee55940d4ffdc97fe0e1
        }
    }
}//method for win lose conditions

