﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Day
    {
        public Weather weather;
        public Day day;
        public Customer customer;
        public double dailyprofit;
        public double startofdaybalance;
        public string weatheroftheday;
        public int customerCount;
        public int pricperCup;
        public Player player1;
        public List<Customer> customers;



        public Day()
        {
            customer = new Customer();
            customers = new List<Customer>();

            weather = new Weather();
        }


        public void DisplayStartOfDayBalance(Wallet wallet)
        {
            startofdaybalance = wallet.Money;
            Console.WriteLine("your starting balance of the day " + startofdaybalance);
        }
        public void DisplayDailyProfits(Wallet wallet)
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

        public void AddCustomer()
        {
            int amountOfCutomers = CustomerCount();
            for (int i = 0; i < amountOfCutomers; i++)
            {
                customers.Add(new Customer());
            }
        }



        public void CustomerBuyLemonade()
        {
            foreach (Customer customer in customers)
            {
                bool decision = customer.DesicionToBuy(weather, player1.recipe);

            }
        }

        public void DayStart()
        {
            weather.Weathercontrol();
            weather.TemperatureSet();
            AddCustomer();



        }
    }
}
