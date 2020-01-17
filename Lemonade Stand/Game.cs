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
        Store store;
        Weather weather;

       
        
        public Game()
        {

            store = new Store();
            player = new Player();
            

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
            
            store.InventoryAquisition(player.wallet1, player.inventory1);

        }
    }
}//method for win lose conditions

