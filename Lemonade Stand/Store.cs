using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Store
    {//Member varibales 
       public  double pricePerCup;
       public  double pricePerLemon;
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

        //methods
        public void InventoryAquisition(Wallet BMF, Inventory stuff)
        {
            bool walkoutdoor = false;
            while(!walkoutdoor)
            {

            
            Console.WriteLine("Please pick your item and write in the amount you want. An remember don't break the bank buy items");
            string choice = Console.ReadLine();

                switch (choice)
                {
                    case "lemons":

                        Console.WriteLine("How many lemons would you like to purchase? ");
                        int lemonQuantity = Convert.ToInt32(Console.ReadLine());
                         double cost = lemonQuantity * pricePerLemon;

                        if (BMF.Money >= cost)
                        {
                            Console.WriteLine("you have purchased" + lemonQuantity);
                        }
                        else
                        {
                            Console.WriteLine("you need more money for this come back later ");
                        }
                        break;
                        
                        
       
                    case "sugar":
                        Console.WriteLine("How many sugarcubes would you like to purchase? ");
                        int sugarQuantity = Convert.ToInt32(Console.ReadLine());
                         cost = sugarQuantity * pricePerSugar;

                        if (BMF.Money >= cost)
                        {
                            Console.WriteLine("you have purchased" + sugarQuantity);
                        }
                        else
                        {
                            Console.WriteLine("you need more money for this come back later ");
                        }
                        break;
                      
                    case "ice":
                        Console.WriteLine("How many lemons would you like to purchase? ");
                        int iceQuantity = Convert.ToInt32(Console.ReadLine());
                        cost = iceQuantity * pricePerIceCube;

                        if (BMF.Money >= cost)
                        {
                            Console.WriteLine("you have purchased" + iceQuantity);
                        }
                        else
                        {
                            Console.WriteLine("you need more money for this come back later ");
                        }

                        break;    
             
                    case "cups":
                       Console.WriteLine("How many lemons would you like to purchase? ");
                       int cupQuantity = Convert.ToInt32(Console.ReadLine());
                        cost = cupQuantity * pricePerCup;

                        if (BMF.Money >= cost)
                        {
                            Console.WriteLine("you have purchased" + cupQuantity);
                        }
                        else
                        {
                            Console.WriteLine("you need more money for this come back later ");
                        }

                        break;

                    case "back out of menu":
                        break;

                    default:
                        Console.WriteLine("Invalid Input Please Try Again!");
                        break;
                }
            }

        }
    }
}

