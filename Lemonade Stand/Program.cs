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
            Game letsgo = new Game();
            letsgo.Start();
            Recipe recipe = new Recipe();
            recipe.setPricePerCup();
            recipe.SetRecipe();
            Console.ReadLine();
        }
    }
}
