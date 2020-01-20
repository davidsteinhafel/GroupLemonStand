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
        public double dailyprofit;
        public double startofdaybalance;
        public string weatheroftheday;
        public int customerCount;
        public int pricperCup;
        public Player player1;
        List<Customer> customers;
        

        public Day()
        {
            player1 = new Player();
            customers = new List<Customer>();
            days = 0;
            customers = new List<Customer>();
            weather = new Weather();
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


        public int CustomerCount()
        {
            switch (weather.Weathercontrol())
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

        
        
        public void CustomerBuyLemonade()
        {
            Random random = new Random();
            int rng = random.Next(11);
            
        }

      


    }
}
