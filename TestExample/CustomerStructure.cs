using System;
using System.Collections.Generic;
using System.Text;

namespace TestExample
{
    class CustomerStructure
    {
        private List<Customer> customers = new List<Customer>();

        public void Attach(Customer customer) => customers.Add(customer);

        public void Detach(Customer customer) => customers.Remove(customer);

        public void Accept(Taxi taxi)
        {
            foreach (var customer in customers)
                customer.Accept(taxi);
        }

    }
}
