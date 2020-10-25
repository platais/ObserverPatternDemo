using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();

            NewsAgency agency1 = new NewsAgency("Best News Agency");
            weatherStation.Attach(agency1);
            NewsAgency agency2 = new NewsAgency("Fake News Agency");
            weatherStation.Attach(agency2);
            NewsAgency agency3 = new NewsAgency("Yellow Press Agency");
            weatherStation.Attach(agency3);

            weatherStation.Temp = 18.4f;
            weatherStation.Temp = 25.6f;
            weatherStation.Temp = 31.4f;
            weatherStation.Temp = 14.4f;
            weatherStation.Temp = 29.6f;

            Console.ReadKey();
        }
    }
}
