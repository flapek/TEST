using System;
using System.Collections.Generic;
using System.Text;

namespace TestExample
{
    class Dispenser200 : IDispenseChain
    {
        private IDispenseChain chain;

        public void Dispense(Currency currency)
        {
            var amount = currency.GetAmount();
            if (amount >= 200)
            {
                var num = amount / 200;
                var remainder = amount % 200;
                Console.WriteLine("Dispensing {0} x 200", num);
                if (remainder != 0)
                    chain.Dispense(new Currency(remainder));
            }
            else
                chain.Dispense(currency);
        }

        public void SetNextChain(IDispenseChain nextChain) => chain = nextChain;
    }
}
