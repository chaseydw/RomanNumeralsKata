using NUnit.Framework;

namespace RomanNumeralsKata.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            RomanNumeralsConverter rn = new RomanNumeralsConverter();

            Assert.AreEqual("nulla", rn.Convert(0));
        }

        [Test]
        public void TestReturnValueForOne()
        {
            RomanNumeralsConverter rn = new RomanNumeralsConverter();

            Assert.AreEqual("I", rn.Convert(1));
        }

        [Test]
        public void TestReturnValueForTwo()
        {
            RomanNumeralsConverter rn = new RomanNumeralsConverter();

            Assert.AreEqual("II", rn.Convert(2));
        }

        [Test]
        public void TestReturnValueForTwentyTwo()
        {
            RomanNumeralsConverter rn = new RomanNumeralsConverter();

            Assert.AreEqual("XXII", rn.Convert(22));
        }

        [Test]
        public void TestReturnValueForFourTwentyTwo()
        {
            RomanNumeralsConverter rn = new RomanNumeralsConverter();

            Assert.AreEqual("CDXXII", rn.Convert(422));
        }
        [Test]
        public void TestReturnValueForThreeFourTwentyTwo()
        {
            RomanNumeralsConverter rn = new RomanNumeralsConverter();

            Assert.AreEqual("MMMCDXXII", rn.Convert(3422));
        }
    }
}