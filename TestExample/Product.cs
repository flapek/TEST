using System;
using System.Collections.Generic;

namespace TestExample
{
    internal class Product
    {
        private List<string> parts = new List<string>();

        public void Add(string part) => parts.Add(part);

        public void Show()
        {
            Console.WriteLine("\nProduct Parts -----------------");
            foreach (var part in parts)
                Console.WriteLine(part);
        }
    }
}