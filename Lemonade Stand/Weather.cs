using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Weather
    {
      
       public List<string> weatherConditions;
       public List<string> predictedForecast;
       public  string weather;
       public  int temperature;
       public  string cast;
        Random random;
        public Weather()
        {
            temperature = TemperatureSet(weather);
            
            weatherConditions = new List<string>() { "snow", "sleet", "rain", "sunny", "cloudy" };
            predictedForecast = new List<string>() { "snow", "sleet", "rain", "sunny", "cloudy" };
            random = new Random();
        }
        public string Weathercontrol()
        {
            int rng = random.Next(6);
            weather = weatherConditions[rng];
            Console.WriteLine("this is today's weather " + weather);
            return weather;
            
        }
        //public void Tempcontrol()
        //{
        //    int rng = random.Next(5);
        //    temp = temperature[rng];
        //    random = new Random();
        //    Console.WriteLine("the tempurature today is" + temperature);
        //}
        public void TemperatureSet()
        {
            Random random = new Random();
            int rng = random.Next(11);

            if (weather == "sunny")
            {
                temperature = random.Next(70, 105);
            }
            else if (weather == "cloudy")
            {
                temperature = random.Next(60, 80);
            }
            else if (weather == "sleet")
            {
                temperature = random.Next(25, 40);
            }
            else if (weather == "snow")
            {
                temperature = random.Next(-5, 30);
            }
            else if (weather == "rain")
            {
                temperature = random.Next(50, 70);
            }
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
