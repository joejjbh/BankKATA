using System.Collections.Generic;

namespace BankKata.Library
{

    public class AccountNumbers
    {
        public List<int> accountNumbers = new List<int>();

        public List<int> GetAccountNumbers()
        {
            return accountNumbers;
        }
        

        public List<int> ConvertToAccountNumbers(CollectionOfDigitsAsLineStrings collection)
        {
            var theCollection = collection.GetCollection();
//            var accountNumbers = new List<int>();
            
            var digit = new Digit();

            foreach(var item in theCollection)
            {
                string accountNumber = "";
                var firstLineDigitsList = digit.SeparateIntoSubstrings(item[1]);
                var secondLineDigitsList = digit.SeparateIntoSubstrings(item[2]);
                var thirdLineDigitsList = digit.SeparateIntoSubstrings(item[3]);
                var fourthLineDigitsList = digit.SeparateIntoSubstrings(item[4]);

                for (var index = 0; index < 9; index++)
                {
                    var fullDigitAsString = firstLineDigitsList[index] +
                                            secondLineDigitsList[index] +
                                            thirdLineDigitsList[index] +
                                            fourthLineDigitsList[index];

                    var individualDigit = digit.GetDigitValue(fullDigitAsString);
                    accountNumber += individualDigit;
                }
                accountNumbers.Add(int.Parse(accountNumber));
            }
            return accountNumbers;
        }
    }
    //    public class AccountNumbers
    //    {
    //        public int GetAccountNumber(string firstLineDigits, string secondLineDigits, 
    //                string thirdLineDigits, string fourthLineDigits)
    //        {
    //            var digit = new Digit();
    //            var firstLineDigitsList = digit.SeparateIntoSubstrings(firstLineDigits);
    //            var secondLineDigitsList = digit.SeparateIntoSubstrings(secondLineDigits);
    //            var thirdLineDigitsList = digit.SeparateIntoSubstrings(thirdLineDigits);
    //            var fourthLineDigitsList = digit.SeparateIntoSubstrings(fourthLineDigits);
    //            string accountNumber = "";
    //
    //            for (var index = 0; index < 9; index++)
    //            {
    //                var fullDigitAsString = firstLineDigitsList[index] +
    //                                        secondLineDigitsList[index] +
    //                                        thirdLineDigitsList[index] +
    //                                        fourthLineDigitsList[index];
    //
    //                var individualDigit = digit.GetDigitValue(fullDigitAsString);
    //                accountNumber += individualDigit;
    //            }
    //
    //            return int.Parse(accountNumber);
    //        }
    //    }
}
