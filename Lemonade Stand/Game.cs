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
        public double profitMoney;
        public double cupSold = 0;

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
            PlayGame();
        }
        public void DayStart(Day day)
        {
            UserInterface.DisplayCurrentWeather(day.weather);
            UserInterface.CurrentTemp(day.weather);
            day.CustomerCount();
            day.customer.DesicionToBuy(day.weather, player1.recipe);
        }

        public void GameMenu()
        {
            bool leaveMenu = false;

            while (!leaveMenu)
            {
                Console.WriteLine("Forecast is {0}",week[currentday].weather.predictedForecast);
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
                GameMenu();
                Console.WriteLine($"Current Day: {currentday}");
                DayStart(day);
                currentday++;
                GameOver();

                foreach (Customer customer in day.customers)
                {
                    if (player1.pitcher1.CupsinPitcher == 0 && (player1.inventory1.lemons.Count > 0) && (player1.inventory1.icecubes.Count > 0) && (player1.inventory1.sugarcubes.Count > 0))
                    {
                        UserInterface.DisplayRemainingInventory(player1.inventory1);
                        player1.FillPitcher();
                    }

                    if (player1.pitcher1.CupsinPitcher > 0)
                    {
                        bool didBuy = customer.DesicionToBuy(day.weather, player1.recipe);
                        if (didBuy)
                        {
                            cupSold++;
                            UserInterface.MakeSale(player1);
                        }
                    }

                }
                UserInterface.DisplayCurrentMoney(player1.wallet1);
                profitMoney = cupSold * .50;
                Console.WriteLine("Today you made ${0}", profitMoney);
                UserInterface.DisplayRemainingInventory(player1.inventory1);
                Console.ReadLine();
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
            Random rng = new Random();
            for (int i = 0; i < 7; i++)
            {
                week.Add(new Day(rng));
            }
        }
    }
}








