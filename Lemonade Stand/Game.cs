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
        public Player player1;
        Store store;
        Weather weather;
        public Game()
        {
            store = new Store();
            player1 = new Player();
        }
        public void Start()
        {
            UserInterface.DisplayWelcome();
            UserInterface.DisplayInstructions();
            UserInterface.SetName();
            //money and current day work but temp still needs work!
            //UserInterface.DisplayCurrentMoney(new Wallet());
            //UserInterface.CurrentTemp(new List<int>());
            //UserInterface.DisplayCurrentDay(new Day());
            store.InventoryAquisition(player1);
        }
    }
}//method for win lose conditions

