using System;
using System.Collections.Generic;
using System.Text;

namespace TestExample
{
    class LargePizza : Pizza
    {
        public override double CalculateCost() => 50.00;

        public override string GetName() => "Large Pizza";
    }
}
