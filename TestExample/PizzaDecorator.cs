using System;
using System.Collections.Generic;
using System.Text;

namespace TestExample
{
    class PizzaDecorator : Pizza
    {
        private Pizza pizza;
        public PizzaDecorator(Pizza pizza)
        {
            this.pizza = pizza;
        }
        public override double CalculateCost() => pizza.CalculateCost();

        public override string GetName() => pizza.GetName();
    }
}
