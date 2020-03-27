using System;
using System.Collections.Generic;
using System.Text;

namespace TestExample
{
    class Dispenser100 : IDispenseChain
    {
        private IDispenseChain chain;

        public void Dispense(Currency currency)
        {
            var amount = currency.GetAmount();
            if (amount >= 100)
            {
                var num = amount / 100;
                var remainder = amount % 100;
                Console.WriteLine("Dispensing {0} x 100", num);
                if (remainder != 0)
                    chain.Dispense(new Currency(remainder));
            }
            else
                chain.Dispense(currency);
        }

        public void SetNextChain(IDispenseChain nextChain) => chain = nextChain;
    }
}
