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
        int choice;


     //constructor
     public Store()
     {
            pricePerCup = .50;
            pricePerLemon = .75;
            pricePerSugar = .5;
            pricePerIceCube = .5;
            
     }
        
     //methods
      public void CustomerPurchase()
      {
            

            Console.WriteLine("Please pick your item");
           int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case amountOfCups:
                    Console.WriteLine("You have choosen " + amountofCups + " Cups ");
                    break;
                case amoutOfLemons:
                    Console.WriteLine("You have choosen " + amounoLemons + " Cups " );
                    break;
                case amountofSugarCubes:
                    Console.WriteLine("You have choosen " + amountofSugarCubes + " Sugar Cubes ");
                    break;
                case amountofIceCubes:
                    Console.WriteLine("You have choosen " + amountofIceCubes + " Ice Cubes ");
                default:
                    Console.WriteLine("that is the wrong input please try again");
                    break;

            }
        }

        


    }
}
