using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
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
        [TestCase(" _ |_ | |   ", 6)]
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

        [TestCase("    _  _     _  _  _  _  _ ", "   ")]
        public void ShouldReturnFirstThreeCharactersInTheString(string firstLineDigits, string expectedFirstThreeCharacters)
        {
            var digit = new Digit();
            List<string> result = digit.SeparateIntoSubstrings(firstLineDigits);
            Assert.That(result, Is.EqualTo(expectedFirstThreeCharacters));
        }

        [TestCase("   _  _     _  _  _  _  _ ",
                  " | _| _||_||_ |_   ||_||_|",
                  " ||_  _|  | _||_|  ||_| _|")]
        public void hello(string firstLineDigits, string secondLineDigits)
        {
            
        }
    }
}
