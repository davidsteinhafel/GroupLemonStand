using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Player
        //possibly abstract class?
    {
        public string name;
        public Inventory inventory;
        public Recipe recipe;
        public Pitcher pitcher;
        public Pitcher pitcher1 = new Pitcher();
        public Wallet wallet;
        public Player()
        {

            Wallet BMF = new Wallet();
            //inventory = new Inventory();

        }
        public void SetName()
        {
            Console.WriteLine("Please put your name in");
            name = Console.ReadLine();

        }
        
    }
    
}
