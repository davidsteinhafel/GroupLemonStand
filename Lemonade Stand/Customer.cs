
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Customer
    {
        public List<string> names;
        Random random;
        Weather weather;
        public List<int> customerPreference;

        public Customer()
        {
            random = new Random();
            customerPreference = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        }
        //method for randomized preference- temp and weather

        public void CustomerPreference()
        {

            int rng = random.Next(11);
            int customerChoice = customerPreference[rng];

            Console.WriteLine(customerChoice);

            if (customerChoice > 3)
            {
                //customerChoice = 4 & 3; not sure what this is but it always returned 0
                Console.WriteLine(customerChoice);
                Console.WriteLine("Sale!");
                //method for buying lemonade an giving money to wallet
            }
            else
            {
                Console.WriteLine("No Sale!");
            }

        }
        //method for purchase limit of customer
        public void limitPurchasePrice()
        {

        }

    }
}
