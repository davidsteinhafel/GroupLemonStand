using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Store
    {//Member varibales 

        public double pricePerCup;
        public double pricePerLemon;
        public double pricePerSugar;
        public double pricePerIceCube;
        




        //constructor
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

                Console.WriteLine("Welcome to the Store!!! Press 1 to buy lemons, 2 to buy sugar cubes, 3 to buy ice cubes, and 4 to buy cups");
                UserInterface.UserInput();

                switch (UserInterface.UserInput())
                {
                    case "1":
                        Console.WriteLine("How many lemons would you like to purchase? ");
                        double quantity = UserInterface.ChangeToDouble();
                        double cost = quantity * pricePerLemon;

                        if (player1.wallet1.Money >= cost)
                        {
                            Console.WriteLine("you have purchased {0}", quantity);
                            player1.inventory1.AddLemons(quantity);

                        }
                        else
                        {
                            Console.WriteLine("you need more money for this come back later");
                        }
                        InventoryAquisition(player1);
                        break;

                    case "2":
                        Console.WriteLine("How many sugar cubes would you like to purchase?");
                        quantity = UserInterface.ChangeToDouble();
                        cost = quantity * pricePerSugar;
                        if (player1.wallet1.Money >= cost)
                        {
                            Console.WriteLine("you have purchased" + quantity);
                            player1.inventory1.AddSugarCubes(quantity);

                        }
                        else
                        {
                            Console.WriteLine("you need more money for this come back later");
                        }
                        InventoryAquisition(player1);
                        break;

                    case "3":
                        Console.WriteLine("How many Ice Cubes would you like to purchase?");
                        quantity = UserInterface.ChangeToDouble();
                        cost = quantity * pricePerLemon;

                        if (player1.wallet1.Money >= cost)
                        {
                            Console.WriteLine("you have purchased" + quantity);
                            player1.inventory1.AddIceCubes(quantity);

                        }
                        else
                        {
                            Console.WriteLine("you need more money for this come back later");
                        }
                        InventoryAquisition(player1);
                        break;

                    case "4":
                        Console.WriteLine("How many Cups would you like to purchase?");
                        quantity = UserInterface.ChangeToDouble();
                        cost = quantity * pricePerLemon;
                        if (player1.wallet1.Money >= cost)
                        {
                            Console.WriteLine("you have purchased" + quantity);
                            player1.inventory1.AddCups(quantity);

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

