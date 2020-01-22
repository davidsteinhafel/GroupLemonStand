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
        private Random rng;
        public Day(Random Rng)
        {
            this.rng = Rng;
            customer = new Customer(Rng);
            customers = new List<Customer>();
            weather = new Weather();
            weather.Weathercontrol();
            weather.TemperatureSet();
            weather.PredictForecast();

            CustomerCount();
            AddCustomer();
            
        }
        public void AddCustomer()
        {
            int amountOfCustomers = CustomerCount();
            for (int i = 0; i < amountOfCustomers; i++)
            {
                customers.Add(new Customer(rng));
            }
        }

        public int CustomerCount()
        {
            switch (weather.name)
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
                case "snow":
                    customerCount = 10;
                    return customerCount;
                default:
                    return customerCount;
            }
        }
    }
}
