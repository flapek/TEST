using System;
using System.Collections.Generic;
using System.Text;

namespace TestExample
{
    class SmallPizza : Pizza
    {
        public override double CalculateCost() => 12.00;

        public override string GetName() => "Small Pizza";
    }
}
