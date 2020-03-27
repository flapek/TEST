using System;
using System.Collections.Generic;
using System.Text;

namespace TestExample
{
    class Bidder : IObserver
    {
        private string name;
        public double bidPrice;

        public Bidder(string name)
        {
            this.name = name;
        }

        public void update()
        {
            Console.WriteLine("{0} propose: {1}\n", name, bidPrice);
            if (bidPrice > 450)
                Console.WriteLine("Sold!! {0}", name);
        }

        public void giveNewPrice(double price) => bidPrice = price;
    }
}
