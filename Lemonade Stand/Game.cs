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
           
        }
        public void Start()
        {
            store = new Store();
            player1 = new Player();
            week = new List<Day>();
            currentday = 0;
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
            day.customer.DesicionToBuy(day.weather, player1.recipe);
            
        }
        public void GameMenu()
        {
            bool leaveMenu = false;

            while (!leaveMenu)
            {
                Console.WriteLine("Welcome to game menu press 1 for store, press 2 for Recipe, press 3 for set price of cups of lemonade, press 4 to play game, press 5 to leave game");
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
                DayStart(day);
                GameOver();
                GameMenu();

                foreach (Customer customer in day.customers)
                {

                    if (player1.pitcher1.CupsinPitcher == 0 && (player1.inventory1.lemons.Count > 0) && (player1.inventory1.icecubes.Count > 0) && (player1.inventory1.sugarcubes.Count > 0))
                    {
                        player1.FillPitcher();
                    }

                    if (player1.pitcher1.CupsinPitcher > 0)
                    {
                        bool didBuy = customer.DesicionToBuy(day.weather, player1.recipe);
                        if (didBuy)
                        {
                            UserInterface.MakeSale(player1);
                        }
                       
                    }

                }
                

            }

        }

        public bool GameOver()
        {

           if (currentday == 7)
           {
             Console.WriteLine("GAMEOVER!!!");
                Start();
             return true;
           }
            else
            {
              return false;
            }
        }


        public void GenerateDays()
        {

            for (int i = 0; i < 7; i++)
            {
            week.Add(new Day());

            }
        }
    }
}  









