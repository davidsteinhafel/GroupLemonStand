using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Store
    {//Member varibales 
        double pricePerCup;
        double pricePerLemon;
        double pricePerSugar;
        double pricePerIceCube;
        double bulkLemons;
        double bulkSugar;
        double bulkIceCubes;
        double bulkCups;
        double quanity;

        //constructor
        public Store()
        {
            pricePerCup = .50;
            pricePerLemon = .75;
            pricePerSugar = .5;
            pricePerIceCube = .5;
            quanity = 10;
            bulkLemons = pricePerCup * quanity;
            bulkSugar = pricePerSugar * quanity;
            bulkIceCubes = pricePerIceCube * quanity;
            bulkCups = pricePerCup * quanity;

        }

        //methods
        public void InventoryAquisition()
        {
            Console.WriteLine("Please pick your item. For lemon press 1, for Sugar press 2, for Ice press 3, and for Cups press 4");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":

                    Console.WriteLine("How many lemons would u like to purchase? Press 1 = 10 lemons for $7.50, Press 2 = 15 lemons for $11.25, Press 3 = 20 for $15");
                    string lemonQuantity = Console.ReadLine();
                    switch (lemonQuantity)
                    {
                        case "1":
                            if (lemonQuantity == "1")
                            {
                                //check wallet money method
                                //then if enough money add count to player inventory
                            }
                            break;
                        case "2":
                            if (lemonQuantity == "2")
                            {
                                //check wallet money method
                            }
                            break;
                        case "3":
                            if (lemonQuantity == "3")
                            {
                                //check wallet money method
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Input Please Try Again");
                            break;
                    }
                    break;
                case "2":
                    Console.WriteLine("How many Sugar would u like to purchase? Press 1 = 10 lemons for $7.50, Press 2 = 15 lemons for $11.25, Press 3 = 20 for $15");
                    string sugarQuantity = Console.ReadLine();
                    switch (sugarQuantity)
                    {
                        case "1":
                            if (sugarQuantity == "1")
                            {
                                //check wallet money method
                            }
                            break;
                        case "2":
                            if (sugarQuantity == "2")
                            {
                                //check wallet money method
                            }
                            break;
                        case "3":
                            if (sugarQuantity == "3")
                            {
                                //check wallet money method
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Input Please Try Again");
                            break;
                    }
                    break;
                case "3":
                    Console.WriteLine("How many Ice would u like to purchase? Press 1 = 10 lemons for $7.50, Press 2 = 15 lemons for $11.25, Press 3 = 20 for $15");
                    string iceQuantity = Console.ReadLine();
                    switch (iceQuantity)
                    {
                        case "1":
                            if (iceQuantity == "1")
                            {
                                //check wallet money method
                            }
                            break;
                        case "2":
                            if (iceQuantity == "2")
                            {
                                //check wallet money method
                            }
                            break;
                        case "3":
                            if (iceQuantity == "3")
                            {
                                //check wallet money method
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Input Please Try Again");
                            break;
                    }
                    break;
                case "4":
                    Console.WriteLine("How many Cups would u like to purchase? Press 1 = 10 lemons for $7.50, Press 2 = 15 lemons for $11.25, Press 3 = 20 for $15");
                    string cupsQuantity = Console.ReadLine();
                    switch (cupsQuantity)
                    {
                        case "1":
                            if (cupsQuantity == "1")
                            {
                                //check wallet money method
                            }
                            break;
                        case "2":
                            if (cupsQuantity == "2")
                            {
                                //check wallet money method
                            }
                            break;
                        case "3":
                            if (cupsQuantity == "3")
                            {
                                //check wallet money method
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Input Please Try Again");
                            break;
                    }
                    break;
                case "Quite Menu":

                    break;
                default:
                    Console.WriteLine("Invalid Input Please Try Again!");
                    break;
            }
        }
    }
}

