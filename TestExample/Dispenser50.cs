using System;
using System.Collections.Generic;
using System.Text;

namespace TestExample
{
    class Dispenser50 : IDispenseChain
    {
        private IDispenseChain chain;

        public void Dispense(Currency currency)
        {
            var amount = currency.GetAmount();
            if (amount >= 50)
            {
                var num = amount / 50;
                var remainder = amount % 50;
                Console.WriteLine("Dispensing {0} x 50", num);
                if (remainder != 0)
                    chain.Dispense(new Currency(remainder));
            }
            else
                chain.Dispense(currency);
        }

        public void SetNextChain(IDispenseChain nextChain) => chain = nextChain;
    }
}
