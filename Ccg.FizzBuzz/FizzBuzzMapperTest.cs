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
        [TestCase(13, "13")]
        [TestCase(99, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(51, "51")]
        [TestCase(500, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(300, "FizzBuzz")]
        [TestCase(351, "351")]
        public void TestFizzBuzz(int input, string expected)
        {
            Assert.Equals(_fizzBuzzMapper.Map(input), expected);
        }
    }
}