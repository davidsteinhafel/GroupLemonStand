using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Cup : Item
    {
        ///Liskov substitution principle. Cup inherits from the Item class. based on iheritance and
        ///the liskov property you could effectively interchange this child class with the parent
        ///item class and they would still logically do the same thing without any suprises.

        public Cup()
        {
            name = "Cup";
        }
    }
}
