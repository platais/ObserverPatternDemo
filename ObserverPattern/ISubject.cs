using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    interface ISubject
    {
        void Attach(IObserver observer);
        void Notify();
    }
}
