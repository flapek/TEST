using System;
using System.Collections.Generic;
using System.Text;

namespace TestExample
{
    class HamDecorator : PizzaDecorator
    {
        public HamDecorator(Pizza pizza) : base(pizza)
        {
        }

        public override double CalculateCost() =>
            base.CalculateCost() + 4.15;

        public override string GetName() => base.GetName() + ", Ham";
    }
}
