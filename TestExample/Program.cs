using System;

namespace TestExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DummyProduct product = new DummyProduct();
            Shop shop1 = new Shop("Shop1");
            Shop shop2 = new Shop("Shop2");
            Shop shop3 = new Shop("Shop3");
            Shop shop4 = new Shop("Shop4");
            Shop shop5 = new Shop("Shop5");

            product.Attach(shop1);
            product.Attach(shop2);
            product.Attach(shop3);
            product.Attach(shop4);
            product.Attach(shop5);

            product.ChangePrice(23.0f);
            product.Detach(shop2);

            Console.WriteLine("Zmiana na 8zł");
            product.ChangePrice(8.0f);

        }
    }
}
