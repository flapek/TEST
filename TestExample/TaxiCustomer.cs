using System;
using System.Collections.Generic;
using System.Text;

namespace TestExample
{
    class TaxiCustomer : Customer
    {
        public TaxiCustomer(string name) => this.name = name;

        public override void Accept(Taxi taxi) => taxi.VisitCustomer(this);
    }
}
