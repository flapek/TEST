namespace TestExample
{
    internal class ConcreteBuilder1 : Builder
    {
        private Product product = new Product();
        public override void BuildPartA() => product.Add("PartA");

        public override void BuildPartB() => product.Add("PartB");

        public override Product GetResult() => product;
    }
}