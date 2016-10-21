using System.Collections.Generic;
using BankKata.Library;
using NUnit.Framework;

namespace BankKata.Tests
{
    [TestFixture]
    public class DigitTests
    {
        [TestCase("     |  |   ", 1)]
        [TestCase(" _  _||_    ", 2)]
        [TestCase(" _  _| _|   ", 3)]
        [TestCase("   |_|  |   ", 4)]
        [TestCase(" _ |_  _|   ", 5)]
        [TestCase(" _ |_ |_|   ", 6)]
        [TestCase(" _   |  |   ", 7)]
        [TestCase(" _ |_||_|   ", 8)]
        [TestCase(" _ |_| _|   ", 9)]
        [TestCase(" _ | | _    ", 0)]
        public void ShouldReturnPipesAndUnderScoresAsValue(string digitAsString, int expectedValue)
        {
            var digit = new Digit();
            var result = digit.GetDigitValue(digitAsString);
            Assert.That(result, Is.EqualTo(expectedValue));
        }

        [TestCase("    _  _     _  _  _  _  _ ", 
                  "   "," _ "," _ ","   "," _ "," _ "," _ "," _ "," _ ")]
        public void ShouldReturnFirstThreeCharactersInTheString(string firstLineDigits, string expectedFirstString, 
                string expectedSecondString, string expectedThirdString, string expectedFourthString,
                string expectedFifthString, string expectedSixthString, string expectedSeventhString,
                string expectedEightString, string expectedNinthString)
        {
            var digit = new Digit();
            List<string> result = digit.SeparateIntoSubstrings(firstLineDigits);
            Assert.That(result[0], Is.EqualTo(expectedFirstString));
            Assert.That(result[1], Is.EqualTo(expectedSecondString));
            Assert.That(result[2], Is.EqualTo(expectedThirdString));
            Assert.That(result[3], Is.EqualTo(expectedFourthString));
            Assert.That(result[4], Is.EqualTo(expectedFifthString));
            Assert.That(result[5], Is.EqualTo(expectedSixthString));
            Assert.That(result[6], Is.EqualTo(expectedSeventhString));
            Assert.That(result[7], Is.EqualTo(expectedEightString));
            Assert.That(result[8], Is.EqualTo(expectedNinthString));
        }

        [TestCase("    _  _     _  _  _  _  _ ",
                  "  | _| _||_||_ |_   ||_||_|",
                  "  ||_  _|  | _||_|  ||_| _|",
                  "                           ",123456789)]
        public void ShouldReturnDigitsAsNumbers(string firstLineDigits, string secondLineDigits, 
                string thirdLineDigits, string fourthLineDigits, int expectedAccountNumber)
        {
            var accountNumber = new AccountNumbers();
            var result = accountNumber.ConvertToAccountNumbers(firstLineDigits, secondLineDigits, thirdLineDigits, fourthLineDigits);
            Assert.That(result, Is.EqualTo(expectedAccountNumber));
        }

        [Test]
        public void  
    }
}
