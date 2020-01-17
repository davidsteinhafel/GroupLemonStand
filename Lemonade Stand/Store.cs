using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Store
    {//Member varibales 
<<<<<<< HEAD
       public  double pricePerCup;
       public  double pricePerLemon;
       public double pricePerSugar;
       public double pricePerIceCube;
       
        
       
=======
        public double pricePerCup;
        public double pricePerLemon;
        public double pricePerSugar;
        public double pricePerIceCube;


>>>>>>> 61bf75abf91a3278cf03ee55940d4ffdc97fe0e1

        //constructor
        public Store()
        {
            pricePerCup = .50;
            pricePerLemon = .75;
            pricePerSugar = .5;
            pricePerIceCube = .5;


        }

        //methods
<<<<<<< HEAD
        public void InventoryAquisition(Wallet wallet1, Inventory stuff)
=======
        public void InventoryAquisition(Wallet wallet, Inventory stuff)
>>>>>>> 61bf75abf91a3278cf03ee55940d4ffdc97fe0e1
        {

            bool walkoutdoor = false;
<<<<<<< HEAD
            int lemonQuantity = 0;
            int sugarQuantity = 0;
            int cupQuantity = 0;
            int iceQuantity = 0;
            while(!walkoutdoor)
=======
            while (!walkoutdoor)
>>>>>>> 61bf75abf91a3278cf03ee55940d4ffdc97fe0e1
            {


                Console.WriteLine("Please pick what you would item you would like to buy: For lemons press 1, sugar cubes press 2, ice cubes press 3, and cups press 4");
                UserInterface.UserInput();

                switch (UserInterface.UserInput())
                {
                    case "1":

<<<<<<< HEAD
                        Console.WriteLine("How many lemons would you like to purchase? " );
                        lemonQuantity = Convert.ToInt32(Console.ReadLine());
                         double cost = lemonQuantity * pricePerLemon;

                        if (wallet1.Money >= cost)

                        {
                            Console.WriteLine("you have purchased " + lemonQuantity);
                            stuff.AddLemons(lemonQuantity);


=======
                        Console.WriteLine("How many lemons would you like to purchase? ");
                        double quantity = UserInterface.ChangeToDouble();
                        double cost = quantity * pricePerLemon;


                        if (wallet.Money >= cost)
                        {
                            Console.WriteLine("you have purchased {0}", quantity);
>>>>>>> 61bf75abf91a3278cf03ee55940d4ffdc97fe0e1
                        }
                        else
                        {
                            Console.WriteLine("you need more money for this come back later");
                        }

                        break;
<<<<<<< HEAD
                        
                        
       
                    case "sugar":
                        Console.WriteLine("How many sugarcubes would you like to purchase? ");
                        sugarQuantity = Convert.ToInt32(Console.ReadLine());
                         cost = sugarQuantity * pricePerSugar;


                        if (wallet1.Money >= cost)

                        {
                            Console.WriteLine("you have purchased " + sugarQuantity);
                            stuff.AddSugarCubes(sugarQuantity);
=======

                    case "2":
                        Console.WriteLine("How many sugarcubes would you like to purchase?");
                        quantity = UserInterface.ChangeToDouble();
                        cost = quantity * pricePerSugar;

                        if (wallet.Money >= cost)
                        {
                            Console.WriteLine("you have purchased" + quantity);
>>>>>>> 61bf75abf91a3278cf03ee55940d4ffdc97fe0e1
                        }
                        else
                        {
                            Console.WriteLine("you need more money for this come back later");
                        }
                        break;
<<<<<<< HEAD
                      
                    case "icecubes":
                        Console.WriteLine("How many icecubes would you like to purchase? ");
                        iceQuantity = Convert.ToInt32(Console.ReadLine());
                        cost = iceQuantity * pricePerIceCube;


                        if (wallet1.Money >= cost)

                        {
                            Console.WriteLine("you have purchased" + iceQuantity);
                            stuff.AddIceCubes(iceQuantity);
=======

                    case "3":
                        Console.WriteLine("How many Ice Cubes would you like to purchase?");
                        quantity = UserInterface.ChangeToDouble();
                        cost = quantity * pricePerLemon;

                        if (wallet.Money >= cost)
                        {
                            Console.WriteLine("you have purchased" + quantity);
>>>>>>> 61bf75abf91a3278cf03ee55940d4ffdc97fe0e1
                        }
                        else
                        {
                            Console.WriteLine("you need more money for this come back later");
                        }

<<<<<<< HEAD
                        break;    
             
                    case "cups":
                       Console.WriteLine("How many cups would you like to purchase? " );
                        cupQuantity = Convert.ToInt32(Console.ReadLine());
                        cost = cupQuantity * pricePerCup;


                        if (wallet1.Money >= cost)

                        {
                            Console.WriteLine("you have purchased" + cupQuantity);
                            stuff.AddCups(cupQuantity);
=======
                        break;

                    case "4":
                        Console.WriteLine("How many Cups would you like to purchase?");
                        quantity = UserInterface.ChangeToDouble();
                        cost = quantity * pricePerLemon;
                        if (wallet.Money >= cost)
                        {
                            Console.WriteLine("you have purchased" + quantity);
>>>>>>> 61bf75abf91a3278cf03ee55940d4ffdc97fe0e1
                        }
                        else
                        {
                            Console.WriteLine("you need more money for this come back later");
                        }

                        break;

<<<<<<< HEAD
                    case "back out":
=======
                    case "back out of menu":

>>>>>>> 61bf75abf91a3278cf03ee55940d4ffdc97fe0e1
                        break;

                    default:
                        Console.WriteLine("Invalid Input Please Try Again!");
                        break;
                }
            }

        }
    }
}

