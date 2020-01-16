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
                    if (choice == "Lemons")
                    {
                        Console.WriteLine("How many lemons would u like to purchase? 10 lemons = $7.50, 15 lemons = $11.25, and 20 = $15");
                        switch (choice)
                        {
                            case "1":
                                if (choice == "1")
                                {

                                }
                                break;
                            case "2":
                                break;
                            case "3":
                                break;
                        }

                    }
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
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
