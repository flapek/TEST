using System;

namespace TestExample
{
    internal class Director
    {
        public Director()
        {
        }

        internal void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}