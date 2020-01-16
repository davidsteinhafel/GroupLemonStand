using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Weather
    {
        public string condition;
        public int temperature;
        public List<string> weatherConditions;
        public string predictedForecast;
        string weather;
        Random random;

        public Weather(string condition, int temperature )
        {
            weatherConditions = new List<string>(){"snow","sleet","rain","sunny","cloudy"};

            random = new Random();
           
        }
        
        public void Weathercontrol()
        {
            int rng = random.Next(4);
            string Outside = weatherConditions[rng];
            Console.WriteLine("the weather today is" + weatherConditions);

            
        }
    }
}
