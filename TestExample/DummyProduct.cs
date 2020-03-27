using System;
using System.Collections.Generic;
using System.Text;

namespace TestExample
{
    class DummyProduct : Subject
    {
        public void ChangePrice(float price)
        {
            Notify(price);
        }
    }
}
