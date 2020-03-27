using System;
using System.Collections.Generic;
using System.Text;

namespace TestExample
{
    abstract class Taxi
    {
        public abstract void VisitCustomer(TaxiCustomer customer);
        public abstract void VisitCustomer(PoorCustomer customer);
        public abstract void VisitCustomer(RichCustomer customer);
    }
}
