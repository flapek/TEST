using System;
using System.Collections.Generic;
using System.Text;

namespace TestExample
{
    class Shop : IObserver
    {
        private string name;
        private float price = 0.0f;

        public Shop(string name)
        {
            this.name = name;
        }

        public void update(float price)
        {
            this.price = price;
            Console.WriteLine("Cena produktu {0} to {1}", name, price);
        }
    }
}
