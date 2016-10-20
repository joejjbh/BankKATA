using System.Collections.Generic;
using System.Linq;

namespace BankKata.Library
{
    public class Digit
    {
        private static readonly Dictionary<string, int> StringDigitValues = new Dictionary<string, int>()
        {
            {"     |  |   ", 1},
            {" _  _||_    ", 2},
            {" _  _| _|   ", 3},
            {"   |_|  |   ", 4},
            {" _ |_  _|   ", 5},
            {" _ |_ |_|   ", 6},
            {" _   |  |   ", 7},
            {" _ |_||_|   ", 8},
            {" _ |_| _|   ", 9},
            {" _ | | _    ", 0},
        };

        public int GetDigitValue(string digitAsString)
        {
            return StringDigitValues[digitAsString];
        }

        public int DigitValue { get; internal set; }

        public List<string> SeparateIntoSubstrings(string lineOfStringDigits)
        {
            var subStrings = new List<string>();
            var separatedStringDigits = Split(lineOfStringDigits, 3);
            foreach (var individualDigitAsString in separatedStringDigits)
            {
                subStrings.Add(individualDigitAsString);
            }
            return subStrings;
        }

        static IEnumerable<string> Split(string lineOfStringDigits, int chunkSize)
        {
            return Enumerable.Range(0, lineOfStringDigits.Length/chunkSize)
                .Select(i => lineOfStringDigits.Substring(i*chunkSize, chunkSize));
        }
    }
}


