using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    interface IWeatherStation
    {
        void Attach(IObserver observer);
        void Notify();
    }
}
