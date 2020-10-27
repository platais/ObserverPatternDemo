using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    class WeatherStation: IWeatherStation
    {
        private List<IObserver> _observers;

        public float Temp
        {
            get { return _temp; }
            set
            {
                _temp = value;
                Notify();
            }
        }
        private float _temp { get; set; }

        public WeatherStation()
        {
            _observers = new List<IObserver>();
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Notify()
        {
            _observers.ForEach(o =>
            {
                o.Update(this);
            });
        }

    }
}
