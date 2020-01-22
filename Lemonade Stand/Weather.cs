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
        public string name;
        public int temperature;
        Random random;

        public Weather()
        {
            weatherConditions = new List<string>() { "snow", "sleet", "rain", "sunny", "cloudy" };
            predictedForecast = new List<string>() { "snow", "sleet", "rain", "sunny", "cloudy" };
            random = new Random((int)DateTime.Now.Ticks);

        }

        public string Weathercontrol()
        {
            int rng = random.Next(5);
            name = weatherConditions[rng];
            return name;


        }

        public void TemperatureSet()
        {
            Random random = new Random();
            int rng = random.Next();

            if (name == "sunny")
            {
                temperature = random.Next(70, 105);

            }
            else if (name == "cloudy")
            {
                temperature = random.Next(60, 80);

            }
            else if (name == "sleet")
            {
                temperature = random.Next(25, 40);

            }
            else if (name == "snow")
            {
                temperature = random.Next(0, 30);

            }
            else if (name == "rain")
            {
                temperature = random.Next(50, 70);

            }
        }
        public void Forcasting()
        {

            int rng = random.Next(5);
            string cast = predictedForecast[rng];
            random = new Random();
            Console.WriteLine("this is the predicted forcast" + cast);
        }


    }
}
