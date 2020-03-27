using System;
using System.Collections.Generic;
using System.Text;

namespace TestExample
{
    interface ISubject
    {
        public void Attach(Shop product);
        public void Detach(Shop product);
        public void Notify(float price);
    }
}
