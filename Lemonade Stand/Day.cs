using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Day
    {

        Weather weather;
        public List<Customer>customers;
        public int days;
        public int dailyprofit;
        public Day()
        {
            days = 7;
        }
    }
}
//run day method for how day operates