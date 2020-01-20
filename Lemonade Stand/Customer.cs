
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
        Weather weather;
        public List<int> customerPreference;
        int customerChoice;



        public Customer()
        {
            random = new Random();
            customerPreference = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
        }
        

        public double CustomerPreference(Weather weather)
        {

            int rng = random.Next(11);
            customerChoice = customerPreference[rng];

            //Console.WriteLine(customerChoice);

            //if (customerChoice > 3)
            //{
            //    //customerChoice = 4 & 3; not sure what this is but it always returned 0
            //    Console.WriteLine(customerChoice);
            //    Console.WriteLine("Sale!");
            //    //method for buying lemonade an giving money to wallet
            //}
            //else
            //{
            //    Console.WriteLine("No Sale!");
            //}
            if(weather.weather == "sunny")
            {
                customerChoice += 2;
            }
            else if (weather.weather == "cloudy")
            {
                customerChoice -= 1;
            }
            else
            {
                customerChoice -= 2;
            }

            if (weather.temp >=40 )
            {
                customerChoice += 2;
            }
            else
            {
                customerChoice -= 2;
            }
            if (customerChoice > 8)
            {
                return 20;
            }
            else if (customerChoice > 6)
            {
                return 10;
            }
            else if (customerChoice > 4)
            {
                return 5;
            }
            else if (customerChoice > 2)
            {
                return 2;
            }
            return 0;

        }


        

    }
}
