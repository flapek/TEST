using System;
using System.Collections.Generic;
using System.Text;

namespace TestExample
{
    class Currency
    {
        private int Amount;

        public Currency(int amount) => Amount = amount;

        public int GetAmount() => Amount;
    }
}
