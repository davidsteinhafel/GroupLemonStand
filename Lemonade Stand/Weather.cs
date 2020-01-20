using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Weather
    {
       public List<int> temperature;
       public List<string> weatherConditions;
       public List<string> predictedForecast;
       public  string weather;
       public  int temp;
       public  string cast;
        Random random;
        public Weather()
        {
            temperature = new List<int>() { -50, -20, 10, 40, 70 };
            weatherConditions = new List<string>() { "snow", "sleet", "rain", "sunny", "cloudy" };
            predictedForecast = new List<string>() { "snow", "sleet", "rain", "sunny", "cloudy" };
            random = new Random();
        }
        public void Weathercontrol()
        {
            int rng = random.Next(4);
            weather = weatherConditions[rng];
            Console.WriteLine("this is today's weather " + weather);
        }
        public void Tempcontrol()
        {
            int rng = random.Next(5);
            temp = temperature[rng];
            random = new Random();
            Console.WriteLine("the tempurature today is" + temperature);
        }
        public void Forcasting()
        {
            int rng = random.Next(4);
            cast = predictedForecast[rng];
            random = new Random();
            Console.WriteLine("this is the predicted forcast" + predictedForecast);
        }
    }
}
