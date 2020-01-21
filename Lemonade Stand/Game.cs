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
            GameMenu();
        }
        public void DayStart(Day day)
        {
            day.weather.Weathercontrol();
            day.weather.TemperatureSet();
            day.CustomerCount();
            //day.customer.DesicionToBuy(day.weather, player1.recipe); not sure if needed here anymore because down in play game loop
        }
        public void GameMenu()
        {
            bool leaveMenu = false;

            while (!leaveMenu)
            {
                Console.WriteLine("Welcome to game menu press 1 for store, press 2 for Recipe, press 3 for set price of cups, press 4 to start day, press 5 to leave menu");

                string gameMenu = Console.ReadLine();
                switch (gameMenu)
                {
                    case "1":
                        store.InventoryAquisition(player1);
                        break;
                    case "2":
                        player1.FillPitcher();
                        break;
                    case "3":
                        player1.recipe.setPricePerCup();
                        break;
                    case "4":
                        PlayGame();
                        break;
                    case "5":
                        leaveMenu = true;
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
                currentday++;
                Console.WriteLine($"Current Day: {currentday}");
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
                            
                        }
                    }
                    else
                    {
                       //if cant make pitcher and out end day
                    }
                    if (gameover())
                    {

                        Console.WriteLine("Better Luck Next Time!");
                    }
                }
            }
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

        //public void AddDays()
        //{
        //    for (int i = 0; i > days.Count; i++)
        //    {
        //        days.Add(new Day());
        //        Console.WriteLine("new day was added");
        //    }
        //}
        

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





