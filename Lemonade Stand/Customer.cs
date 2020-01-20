
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

        public Customer()
        {
            random = new Random();
            customerPreference = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            customerChoice = random.Next(11);
        }
        
        
        

        


        

    }
}
