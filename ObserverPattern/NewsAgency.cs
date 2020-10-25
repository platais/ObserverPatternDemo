using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    class NewsAgency : IObserver
    {
        public string AgencyName { get; set; }

        public NewsAgency(String name)
        {
            AgencyName = name;
        }

        public void Update(ISubject subject)
        {
            WeatherStation weatherStation = subject as WeatherStation;
            if (weatherStation != null)
            {
                Console.WriteLine(String.Format($"{AgencyName} reporting temperature {weatherStation.Temp} degree celsius\n"));
            }
        }
    }
}
