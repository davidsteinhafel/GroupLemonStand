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
        string choice;
        double bulkLemons;
        double bulkSugar;
        double bulkIceCubes;
        double bulkCups;
        double quanity;
        string lemons;
        string iceCubes;
        string cups;
        string sugarCubes;

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
        //make choice to string and in each case have string lemon,cup,..etc choice and then ask them how much and check wallet to see of they have engouh money if they do have enough money put item in inventory and if not restat menu also add quit menu function
        //methods
        public void CustomerPurchase()
        {
            Console.WriteLine("Please pick your item");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "lemon":
                   Console.WriteLine("You have choosen " + pricePerLemon + " Cups ");
                    break;
                case "cups":
                    Console.WriteLine("You have choosen " + pricePerCup + " Cups ");
                    break;
                case "Sugar Cubes":
                    Console.WriteLine("You have choosen " + pricePerSugar + " Sugar Cubes ");
                    break;
                case "IceCubes":
                    Console.WriteLine("You have choosen " + pricePerIceCube + " Ice Cubes ");
                    break;
                case "Quite Menu":
                    Console.WriteLine("See ya next time");
                    break;
                default:
                    Console.WriteLine("that is the wrong input please try again");
                    break;
            }

        }
    }
}


                    
