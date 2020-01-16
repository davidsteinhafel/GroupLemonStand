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
        List<string> weatherConditions;
        public string predictedForecast;
        Random random;

        public Weather(List<string> weatherConditions)
        {
            weatherConditions = new List<string>(){"snow","sleet","rain","sunny","cloudy"};
            random = new Random();
        }
        
        public void Tempcontrol()
        {
            int rng = random.Next(4);

        }
    }
}
