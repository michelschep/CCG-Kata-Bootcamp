using NUnit.Framework;

namespace Ccg.CombinedNumber
{
    public class NumberCombinerTest
    {
        private NumberCombiner _numberCombiner;

        [SetUp]
        public void Setup()
        {
            _numberCombiner = new NumberCombiner();
        }

        [TestCase(new[] {50, 2, 1, 9}, "95021")]
        [TestCase(new[] {5, 50, 56}, "56550")]
        [TestCase(new[] {420, 42, 423}, "42423420")]
        [TestCase(new[] {0, 0, 0}, "0")]
        [TestCase(new[] {1, 1, 1}, "111")]
        [TestCase(new[] {8, 50, 100}, "850100")]
        [TestCase(new[] {2, 1, 4, 7, 4, 8, 3, 6, 4, 7}, "8776444321")]
        public void TestNumberCombiner(int[] input, string expected)
        {
            Assert.Equals(_numberCombiner.Combine(input), expected);
        }
    }
}