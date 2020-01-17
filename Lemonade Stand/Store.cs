using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Store
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

        public void InventoryAquisition(Wallet wallet1, Inventory stuff)

        {

            bool walkoutdoor = false;

           
            while(!walkoutdoor)

            {


                Console.WriteLine("Please pick what you would item you would like to buy: For lemons press 1, sugar cubes press 2, ice cubes press 3, and cups press 4");
                UserInterface.UserInput();

                switch (UserInterface.UserInput())
                {
                    case "1":



                        Console.WriteLine("How many lemons would you like to purchase? ");
                        double quantity = UserInterface.ChangeToDouble();
                        double cost = quantity * pricePerLemon;


                        if (wallet1.Money >= cost)
                        {
                            Console.WriteLine("you have purchased {0}", quantity);
                            stuff.AddLemons(quantity);

                        }
                        else
                        {
                            Console.WriteLine("you need more money for this come back later");
                        }

                        break;


                    case "2":
                        Console.WriteLine("How many sugarcubes would you like to purchase?");
                        quantity = UserInterface.ChangeToDouble();
                        cost = quantity * pricePerSugar;

                        if (wallet1.Money >= cost)
                        {
                            Console.WriteLine("you have purchased" + quantity);
                            stuff.AddSugarCubes(quantity);
                            

                        }
                        else
                        {
                            Console.WriteLine("you need more money for this come back later");
                        }
                        break;

                    case "3":
                        Console.WriteLine("How many Ice Cubes would you like to purchase?");
                        quantity = UserInterface.ChangeToDouble();
                        cost = quantity * pricePerLemon;

                        if (wallet1.Money >= cost)
                        {
                            Console.WriteLine("you have purchased" + quantity);
                            stuff.AddIceCubes(quantity);

                        }
                        else
                        {
                            Console.WriteLine("you need more money for this come back later");
                        }


                        break;

                    case "4":
                        Console.WriteLine("How many Cups would you like to purchase?");
                        quantity = UserInterface.ChangeToDouble();
                        cost = quantity * pricePerLemon;
                        if (wallet1.Money >= cost)
                        {
                            Console.WriteLine("you have purchased" + quantity);
                            stuff.AddCups(quantity);
                        }

                        else
                        {
                            Console.WriteLine("you need more money for this come back later");
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

