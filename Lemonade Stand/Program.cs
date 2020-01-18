using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Customer customer = new Customer();
            customer.CustomerPreference();
            Console.ReadLine();
            Console.WriteLine();
            
            
            //Game letsgo = new Game();
            //letsgo.Start();
            //Recipe recipe = new Recipe();
            //recipe.setPricePerCup();
            //recipe.SetRecipe();
            //Console.ReadLine();
        }
    }
}
