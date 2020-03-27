using System;
using System.Collections.Generic;
using System.Text;

namespace TestExample
{
    interface IDispenseChain
    {
        void SetNextChain(IDispenseChain nextChain);
        void Dispense(Currency currency);
    }
}
