using System;
using System.Collections.Generic;
using System.Text;

namespace TestExample
{
    class PoorCustomer : Customer
    {
        public PoorCustomer(string name) => this.name = name;

        public override void Accept(Taxi taxi) => taxi.VisitCustomer(this);
    }
}
