using System;
using System.Collections.Generic;
using System.Text;

namespace TestExample
{
    interface ISubject
    {
        void registerBidder(IObserver observer);
        void notifyObservers();
    }
}
