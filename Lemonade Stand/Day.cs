using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Day
    {
        public Weather weather;
        public Customer customer;
        public double dailyprofit;
        public int customerCount;
        public int pricperCup;
        public List<Customer> customers;
        


        public Day()
        {
            customer = new Customer();
            customers = new List<Customer>();
            weather = new Weather();
        }


        public int CustomerCount()
        {
            switch (weather.weather)
            {
                case "sunny":
                    customerCount = 30;
                    return customerCount;
                case "cloudy":
                    customerCount = 25;
                    return customerCount;
                case "rainy":
                    customerCount = 20;
                    return customerCount;
                case "sleet":
                    customerCount = 15;
                    return customerCount;
                case "snowy":
                    customerCount = 10;
                    return customerCount;
                default:
                    return customerCount;
            }
        }

        
    }
}
