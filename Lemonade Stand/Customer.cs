
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
        public List<int> customerPrefernce;
        public bool willbuy;




        public Customer()
        {
            random = new Random();
            customerPrefernce = new List<int>() { 1, 2, 3, 4 };
            willbuy = false;
        }
        //method for randomized preference- temp and weather

        public void CustomerPrefernce()
        {
           
            int rng = random.Next(3);
            int customerchoice = customerPrefernce[rng];
             if(willbuy == true)
            {
                customerchoice = 4 & 3;
                Console.WriteLine("customer is buying a cup of lemonade");
                //method for buying lemonade an giving money to wallet
            }
            
             else
            {
                Console.WriteLine("customer will not buy");
            }

        }
        //method for purchase limit of customer
        public void limtPurchasePrice()
        {

        }

    }
}
