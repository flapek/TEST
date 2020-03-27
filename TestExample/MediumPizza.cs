using System;
using System.Collections.Generic;
using System.Text;

namespace TestExample
{
    class MediumPizza : Pizza
    {
        public override double CalculateCost() => 25.00;

        public override string GetName() => " Medium Pizza";
    }
}
