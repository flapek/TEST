using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TestExample
{
    class Subject : ISubject
    {
        private ArrayList list;

        public Subject() => list = new ArrayList();

        public void Attach(Shop product) => list.Add(product);

        public void Detach(Shop product) => list.Remove(product);

        public void Notify(float price)
        {
            foreach (Shop item in list)
            {
                item.update(price);
            }
        }
    }
}
