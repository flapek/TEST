using System;
using System.Collections.Generic;
using System.Text;

namespace TestExample
{
    class Auctioneer : ISubject
    {
        private List<IObserver> observers;

        public Auctioneer() => observers = new List<IObserver>();

        public void displayNewBidderPrice() => notifyObservers();

        public void notifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.update();
            }
        }

        public void registerBidder(IObserver observer) => observers.Add(observer);
    }
}
