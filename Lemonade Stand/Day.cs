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
        public int days;
        public double dailyprofit;
        public double startofdaybalance;
        public string weatheroftheday;
        public List<Customer> customers;

        public Day()
        {
            days = 0;
            customers = new List<Customer>();
            
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
      

       
    }
}
