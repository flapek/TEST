using System;
using System.Collections.Generic;
using System.Text;

namespace TestExample
{
    class Taxi2 : Taxi
    {
        public override void VisitCustomer(TaxiCustomer customer) => Console.WriteLine("Customer {0} has been visited by {1}", customer.name, GetType().Name);

        public override void VisitCustomer(PoorCustomer customer) => Console.WriteLine("Customer {0} cannot go {1}", customer.name, GetType().Name);

        public override void VisitCustomer(RichCustomer customer) => Console.WriteLine("Customer {0} can pay 300$ for {1}", customer.name, GetType().Name);
    }
}
