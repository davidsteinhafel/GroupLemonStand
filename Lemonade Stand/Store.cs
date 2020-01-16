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

        string lemons = "lemons";
        string iceCubes = "iceCubes";
        string cups = 
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
        
     //methods
      public void CustomerPurchase()
      {
            

            Console.WriteLine("Please pick your item");
           string choice = Console.ReadLine();

            switch (choice)
            {
                case "lemon":
                    
                    Console.WriteLine("You have choosen " + pricePerCup + " Cups ");
                    break;
                case "cups":
                    Console.WriteLine("You have choosen " + amounoLemons + " Cups " );
                    break;
                case "Sugar Cubes":
                    Console.WriteLine("You have choosen " + amountofSugarCubes + " Sugar Cubes ");
                    break;
                case "Ice Cubes":
                    Console.WriteLine("You have choosen " + amountofIceCubes + " Ice Cubes ");
                default:
                    Console.WriteLine("that is the wrong input please try again");
                    break;

            }
        }

        


    }
}
