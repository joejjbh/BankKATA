using System.Collections.Generic;
using System.Linq;

namespace BankKata.Library
{
    public class Digit
    {
        private static readonly Dictionary<string, int> digitValue = new Dictionary<string, int>()
        {
            {"     |  |", 1},
            {" _  _||_ ", 2},
            {" _  _| _|", 3},
            {"   |_|  |", 4},
            {" _ |_  _|", 5},
            {" _ |_ |_|", 6},
            {" _   |  |", 7},
            {" _ |_||_|", 8},
            {" _ |_| _|", 9},
            {" _ | | _ ", 0},
          };

        public int GetDigitValue(string digitAsString)
        {
            return digitValue[digitAsString];
        }

        public int DigitValue { get; internal set; }

        public List<string> SeparateIntoSubstrings(string LineStringDigits)
        {
            var individualDigits = new List<string>();
            var separatedStringDigits = Split(LineStringDigits, 3);
            foreach (var individualDigitAsString in separatedStringDigits)
            {
                individualDigits.Add(individualDigitAsString);
            }
            return individualDigits;
        }

        static IEnumerable<string> Split(string str, int chunkSize)
        {
            return Enumerable.Range(0, str.Length / chunkSize)
                .Select(i => str.Substring(i * chunkSize, chunkSize));
        }

        public int GetAccountNumber(string firstLineDigits, string secondLineDigits, string thirdLineDigits)
        {
            var firstLineDigitsList = SeparateIntoSubstrings(firstLineDigits);
            var secondLineDigitsList = SeparateIntoSubstrings(secondLineDigits);
            var thirdLineDigitsList = SeparateIntoSubstrings(thirdLineDigits);
            string accountNumber = "";

            for (int index = 0; index < 9; index++)
            {
                var fullDigitAsString = firstLineDigitsList[index] + 
                                           secondLineDigitsList[index] +
                                           thirdLineDigitsList[index];
                var digit = GetDigitValue(fullDigitAsString);
                accountNumber += digit;
            }

            return int.Parse(accountNumber);
        }
    }
}

