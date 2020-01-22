using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Wallet
    {
        //solid priniciple "O" open and closed principle
        private double money;
        public double Money
        {
            get
            {
                return money;
            }
            set
            {
                if (value < 0)
                {
                    money = 0;
                }
                else
                {
                    money = value;
                }
            }
        }
        public Wallet()
        {

            money = 50;


        }
    }
}
