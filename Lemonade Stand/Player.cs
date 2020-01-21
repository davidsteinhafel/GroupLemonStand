using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Player

    {
        public string name;
        public Recipe recipe;
        public Pitcher pitcher1;
        public Wallet wallet1;
        public Inventory inventory1;

        public Player()
        {
            wallet1 = new Wallet();
            pitcher1 = new Pitcher();
            recipe = new Recipe();
            inventory1 = new Inventory();
            
        }
        
        public void FillPitcher()
        {
            recipe.SetRecipe();
            Console.WriteLine("filling pitcher....");
            Console.ReadLine();
            inventory1.lemons.RemoveRange(0, recipe.amountOfLemons);
            inventory1.sugarcubes.RemoveRange(0, recipe.amountOfSugarCubes);
            inventory1.icecubes.RemoveRange(0, recipe.amountOfIceCubes);
            pitcher1.CupsinPitcher += 8;
            UserInterface.DisplayRemainingInventory(inventory1);
        }
        
    }
}
