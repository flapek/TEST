using NUnit.Framework;
using TestExample;

namespace UnitTest
{
    public class Tests
    {
        private LocalEuroCalculator localEuroCalculator;

        [SetUp]
        public void Setup()
        {
            localEuroCalculator = new LocalEuroCalculator();
        }

        [Test]
        public void Test1()
        {
            decimal input = 50.0m;
            decimal euroRate = 4.35m;
            decimal correctResult = 217.5m;

            decimal result = localEuroCalculator.Calculate(input, euroRate);

            Assert.AreEqual(correctResult, result);
        }
    }
}