using System;

namespace TestExample
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerStructure customer = new CustomerStructure();
            customer.Attach(new TaxiCustomer("Sam"));
            customer.Attach(new TaxiCustomer("John"));
            customer.Attach(new TaxiCustomer("Carl"));
            customer.Attach(new PoorCustomer("David"));
            customer.Attach(new RichCustomer("McOnnel"));

            Taxi taxi1 = new Taxi1();
            Taxi taxi2 = new Taxi2();

            customer.Accept(taxi1);
            Console.WriteLine();

            customer.Accept(taxi2);

        }
    }
}
