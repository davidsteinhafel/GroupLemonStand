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
        public int days;
        public int maxdays;
        public double dailyprofit;
        public double startofdaybalance;
        public string weatheroftheday;
        public double customerCount;
        List<Customer> customers;
        public Day()
        {
            customers = new List<Customer>();
            days = 0;
            maxdays = 7;
        }

        public void displaystartofdaybalance(Wallet wallet)
        {
            startofdaybalance = wallet.Money;
            Console.WriteLine("your starting balance of the day " + startofdaybalance);
        }
        public void displaydailyprofits(Wallet wallet)
        {
            dailyprofit = wallet.Money - startofdaybalance;
            Console.WriteLine("this is how much moneny you made " + dailyprofit);
        }
        public void CustomerCount()
        {
            switch (weather.Weathercontrol())
            {
                case "sunny":
                    customerCount = 30;
                    break;
                case "cloudy":
                    customerCount = 25;
                    break;
                case "rainy":
                    customerCount = 20;
                    break;
                case "sleet":
                    customerCount = 15;
                    break;
                case "snowy":
                    customerCount = 10;
                    break;
            }
        }

       
    }
}
