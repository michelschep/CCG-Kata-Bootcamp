using NUnit.Framework;

namespace Ccg.FizzBuzz
{
    public class FizzBuzzMapperTest
    {
        private FizzBuzzMapper _fizzBuzzMapper;

        [SetUp]
        public void Setup()
        {
            _fizzBuzzMapper = new FizzBuzzMapper();
        }

        [TestCase(0, "0")]
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(99, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(500, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(300, "FizzBuzz")]
        public void TestFizzBuzz(int input, string expected)
        {
            Assert.Equals(_fizzBuzzMapper.Map(input), expected);
        }
    }
}