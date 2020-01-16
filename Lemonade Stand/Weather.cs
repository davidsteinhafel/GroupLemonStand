using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Weather
    {
        
        public List <int> Temperature;
        public List<string> weatherConditions;
        public List <string> predictedForecast;
        Random random;

        public Weather()
        {
            Temperature = new List<int>() { -50, -20, 10, 40, 70 };
            weatherConditions = new List<string>(){"snow","sleet","rain","sunny","cloudy"};
            predictedForecast = new List<string>() { "snow", "sleet", "rain", "sunny" ,"cloudy" };
            random = new Random();
           
        }
        
        public void Weathercontrol()
        {
            int rng = random.Next(4);
            string weather = weatherConditions[rng];
            Console.WriteLine("the weather today is" + weatherConditions);

            
        }

        public void Tempcontrol()
        {
            int rng = random.Next(5);
            int temp = Temperature[rng];
            random = new Random();

        }

        public void Forcasting()
        {
            int rng = random.Next(4);
            string cast = predictedForecast[rng];
            random = new Random();
        }
    }
}
