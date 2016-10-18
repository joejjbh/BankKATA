namespace BankKata.Library
{
    public class AccountNumber
    {
        public int GetAccountNumber(string firstLineDigits, string secondLineDigits, string thirdLineDigits)
        {
            var digit = new Digit();
            var firstLineDigitsList = digit.SeparateIntoSubstrings(firstLineDigits);
            var secondLineDigitsList = digit.SeparateIntoSubstrings(secondLineDigits);
            var thirdLineDigitsList = digit.SeparateIntoSubstrings(thirdLineDigits);
            string accountNumber = "";

            for (int index = 0; index < 9; index++)
            {
                var fullDigitAsString = firstLineDigitsList[index] +
                                        secondLineDigitsList[index] +
                                        thirdLineDigitsList[index];
                var individualDigit = digit.GetDigitValue(fullDigitAsString);
                accountNumber += individualDigit;
            }

            return int.Parse(accountNumber);
        }
    }
}
