using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Game
    {

        List<Day> week;
        Player player1;
        Store store;
        int currentday;


        public Game()
        {
            store = new Store();
            player1 = new Player();

            week = new List<Day>();

            currentday = 0;

        }

        public void Start()
        {
            UserInterface.DisplayWelcome();
            UserInterface.DisplayInstructions();
            UserInterface.SetName();
            GenerateDays();
            PlayGame();

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

            while (!leavemenu)
            {
                Console.WriteLine("Welcome to game menu press 1 for store, press 2 for Recipe, press 3 for set price of cups, press 4 to start day");

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
                        leavemenu = true;
                        break;
                    default:
                        Console.WriteLine("invalid respone please make another choice!");
                        break;
                }
            }
        }

        public void PlayGame()
        {
            foreach (Day day in week)
            {
                GameMenu();
                foreach (Customer customer in day.customers)
                {
                    if(player1.pitcher1.CupsinPitcher == 0 && (player1.inventory1.lemons.Count > 0) && (player1.inventory1.icecubes.Count > 0) && (player1.inventory1.sugarcubes.Count > 0))
                    {
                        player1.FillPitcher();
                    }
                    
                    if (player1.pitcher1.CupsinPitcher > 0)
                    {
                        bool didBuy = customer.DesicionToBuy(day.weather, player1.recipe);
                        if (didBuy)
                        {
                            UserInterface.MakeSale(player1, player1.wallet1, player1.pitcher1);
                        }
                        else
                        {
                            Console.WriteLine("No Sale!");
                        }
                    }
                    else
                    {
                        // then could not make new pitcher end day
                    }

                }
                if (gameover())
                {
                    // stop game
                }
            }
        }
        public void GenerateDays()
        {
            for (int i = 0; i < 7; i++)
            {
                week.Add(new Day());
            }
        }
        
        //public void CustomerBuyLemon()
        //{
        //    foreach (Customer customer in days.customers)

        //        if (customer.DesicionToBuy(day.weather, player1.recipe) == true)
        //        {
        //            UserInterface.MakeSale(player1, player1.wallet1, player1.pitcher1);
        //        }

        //}



    }



}





