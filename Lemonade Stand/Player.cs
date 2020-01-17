using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Player
        //possibly abstract class?
    {
        public string name;
        public Inventory inventory;
        public Recipe recipe;
        public Pitcher pitcher;
        public Pitcher pitcher1 = new Pitcher();
        public Wallet wallet1;
        public Player()

        { 
            
            wallet1 = new Wallet();
            inventory = new Inventory();


        }
        public void SetName()
        {
            Console.WriteLine("Please put your name in");
            name = Console.ReadLine();

        }
        
    }
    
}
