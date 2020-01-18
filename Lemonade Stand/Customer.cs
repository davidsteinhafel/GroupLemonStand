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
        public Customer()
        {
            random = new Random();
        }
        //method for randomized preference- temp and weather
        //method for purchase limit of customer
    }
}
