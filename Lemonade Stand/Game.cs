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
        Player player1;
        Store store;
        Customer customer;
        Random random;
        int currentday;
        

        public Game()
        {
            store = new Store();
            player1 = new Player();
            random = new Random();
            days = new List<Day>();
            day = new Day();
            currentday = 0;

        }
        
        public void Start()
        {
            UserInterface.DisplayWelcome();
            UserInterface.DisplayInstructions();
            UserInterface.SetName();
            GameMenu();
            gameover();
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
        
        public void GameMenu()
        {
            
            bool leavemenu = false;

            while(!leavemenu)
            {
                Console.WriteLine("Welcome to game menu press 1 for store, press 2 for Recipe, press 3 for set price of cups,press 4 for start day, press 5 for leave menu");
                 
                string gamemenu = Console.ReadLine();
                switch (gamemenu)
                {
                    case "1":
                        store.InventoryAquisition(player1);
                        break;
                    case "2":
                       player1.recipe.SetRecipe();
                        break;
                    case "3":
                       player1.recipe.setPricePerCup();
                        break;
                   case "4":
                        
                        break;
                    case "5":
                        leavemenu = true;
                        break;
                    default:
                        Console.WriteLine("invalid respone please make another choice!");
                        break;

                }
            }

            
            

        }  
        public void AddDay()
        {
            for (int i = 8; i > days.Count;i++)
            {
                days.Add(new Day());
                currentday++;
            }
        }

        public void Playgame()
        {
            bool playgame = false;
            while(playgame!= false)
            { 
                  


            }
            
              
            

        }
       

            
        
     

    }

}

