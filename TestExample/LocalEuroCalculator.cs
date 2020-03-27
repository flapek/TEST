using System;

namespace TestExample
{
    public class LocalEuroCalculator
    {
        public LocalEuroCalculator()
        {
        }

        public decimal Calculate(decimal input, decimal euroRate) => 
            input * euroRate;
    }
}