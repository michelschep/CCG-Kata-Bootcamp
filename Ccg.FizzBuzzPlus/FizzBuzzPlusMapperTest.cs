using NUnit.Framework;

namespace Ccg.FizzBuzz
{
    public class FizzBuzzPlusMapperTest
    {
        private FizzBuzzPlusMapper _fizzBuzzPlusMapper;

        [SetUp]
        public void Setup()
        {
            _fizzBuzzPlusMapper = new FizzBuzzPlusMapper();
        }

        [TestCase(0, "0")]
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(13, "Fizz")]
        [TestCase(99, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(51, "Buzz")]
        [TestCase(500, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(300, "FizzBuzz")]
        [TestCase(351, "FizzBuzz")]
        public void TestFizzBuzz(int input, string expected)
        {
            Assert.Equals(_fizzBuzzPlusMapper.Map(input), expected);
        }
    }
}