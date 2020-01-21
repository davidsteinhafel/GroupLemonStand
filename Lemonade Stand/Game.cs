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
        double startMoney;
        double endMoney;
        public double profitMoney;
        public double cupSold = 0;
        
        

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
        public void DayStart(Day day)
        {
            day.weather.Weathercontrol();
            day.weather.TemperatureSet();
            UserInterface.DisplayCurrentWeather(day.weather);
            UserInterface.CurrentTemp(day.weather);
            day.CustomerCount();
            UserInterface.DisplayCurrentMoney(player1.wallet1);



            //day.customer.DesicionToBuy(day.weather, player1.recipe); not sure if needed here anymore because down in play game loop
        }

        public void GameMenu()
        {
            bool leaveMenu = false;

            while (!leaveMenu)
            {
                Console.WriteLine("Welcome to game menu press 1 for store, press 2 for Recipe, press 3 for set price of cups, press 4 to start day");

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
                DayStart(day);


                currentday++;
                Console.WriteLine($"Current Day: {currentday}");



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
                            cupSold++;  
                            UserInterface.MakeSale(player1, player1.wallet1, player1.pitcher1);
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        Console.WriteLine("Out of lemonade!");
                    }
                    if (gameover())
                    {

                        Console.WriteLine("Better Luck Next Time!");
                    }

                    
                }

                profitMoney = cupSold * .50;
                Console.WriteLine("Today you made ${0}",profitMoney);
                Console.ReadLine();

                //UserInterface.DisplayCurrentMoney(player1.wallet1);
                //UserInterface.DisplayCurrentWeather(day.weather);
                //UserInterface.DisplayRemainingInventory(player1.inventory1);

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





