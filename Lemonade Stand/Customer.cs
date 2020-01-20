
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Customer
    {

        Random random;
        public List<int> customerPreference;
        int customerChoice;
        bool customerBuy;
        
        public Customer()
        {
            random = new Random();
           
            customerChoice = random.Next(11);
            customerBuy = false;
           
        }
        

    }
}
