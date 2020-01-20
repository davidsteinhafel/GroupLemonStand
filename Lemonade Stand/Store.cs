using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Store
    {
        public double pricePerCup;
        public double pricePerLemon;
        public double pricePerSugar;
        public double pricePerIceCube;
        public Store()
        {
            pricePerCup = .50;
            pricePerLemon = .75;
            pricePerSugar = .5;
            pricePerIceCube = .5;
        }
        public void InventoryAquisition(Player player1)
        {
            bool walkoutdoor = false;
            while (!walkoutdoor)
            {
                Console.WriteLine("Welcome to the Store " + " !!! Press 1 to buy lemons, 2 to buy sugar cubes, 3 to buy ice cubes, 4 to buy cups, and 5 to leave store");
                switch (UserInterface.UserInput())
                {
                    case "1":
                        Console.WriteLine("How many lemons would you like to purchase?");
                        Console.WriteLine("Lemons cost {0} per lemon", pricePerLemon);
                        double quantity = UserInterface.ChangeToDouble();
                        double cost = quantity * pricePerLemon;
                        UserInterface.DisplayRemainingInventory(player1.inventory1);
                        

                        if (player1.wallet1.Money >= cost)
                        {
                            Console.WriteLine("you have purchased {0}", quantity);
                            player1.inventory1.AddLemons(quantity);
                            Console.WriteLine("thanks for buying {0} lemons for ${1}", quantity, cost);
                            player1.wallet1.Money -= cost;
                            UserInterface.DisplayCurrentMoney(player1.wallet1);
                        }
                        else
                        {
                            Console.WriteLine("you need more money for this come back later");
                        }
                        InventoryAquisition(player1);
                        break;

                    case "2":
                        Console.WriteLine("How many sugar cubes would you like to purchase?");
                        Console.WriteLine("Sugar cubes cost {0} per cube", pricePerSugar);
                        quantity = UserInterface.ChangeToDouble();
                        cost = quantity * pricePerSugar;
                        if (player1.wallet1.Money >= cost)
                        {
                            Console.WriteLine("you have purchased" + quantity);
                            player1.inventory1.AddSugarCubes(quantity);
                            Console.WriteLine("thanks for buying {0} sugar cubes for ${1}", quantity, cost);
                            player1.wallet1.Money -= cost;
                            UserInterface.DisplayCurrentMoney(player1.wallet1);
                        }
                        else
                        {
                            Console.WriteLine("you need more money for this come back later");
                        }
                        InventoryAquisition(player1);
                        break;

                    case "3":
                        Console.WriteLine("How many Ice Cubes would you like to purchase?");
                        Console.WriteLine("Price per Ice Cube is = {0}", pricePerIceCube);
                        quantity = UserInterface.ChangeToDouble();
                        cost = quantity * pricePerIceCube;

                        if (player1.wallet1.Money >= cost)
                        {
                            Console.WriteLine("you have purchased" + quantity);
                            player1.inventory1.AddIceCubes(quantity);
                            Console.WriteLine("thanks for buying {0} ice cubes for ${1}", quantity, cost);
                            player1.wallet1.Money -= cost;
                            UserInterface.DisplayCurrentMoney(player1.wallet1);

                        }
                        else
                        {
                            Console.WriteLine("you need more money for this come back later");
                        }
                        InventoryAquisition(player1);
                        break;

                    case "4":
                        Console.WriteLine("How many cups would you like to purchase?");
                        Console.WriteLine("Price per cup is = {0}", pricePerCup);
                        quantity = UserInterface.ChangeToDouble();
                        cost = quantity * pricePerCup;
                        if (player1.wallet1.Money >= cost)
                        {
                            Console.WriteLine("you have purchased" + quantity);
                            player1.inventory1.AddCups(quantity);
                            Console.WriteLine("thanks for buying {0} cups for ${1}", quantity, cost);
                            player1.wallet1.Money -= cost;
                            UserInterface.DisplayCurrentMoney(player1.wallet1);

                        }
                        else
                        {
                            Console.WriteLine("you need more money for this come back later");
                        }
                        InventoryAquisition(player1);
                        break;
                    case "5":
                        Console.WriteLine("Thanks for visiting and good luck!!!");

                        break;
                    default:
                        Console.WriteLine("Invalid Input Please Try Again!");
                        InventoryAquisition(player1);
                        break;
                }
            }
        }
    }
}

