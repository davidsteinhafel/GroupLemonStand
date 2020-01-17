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

        public Recipe recipe1;
        public Pitcher pitcher1;
        public Wallet wallet1;
        public Inventory inventory1;

        public Player()
        {
            wallet1 = new Wallet();
            pitcher1 = new Pitcher();
            inventory1 = new Inventory();
            recipe1 = new Recipe();





        }

    }

}
