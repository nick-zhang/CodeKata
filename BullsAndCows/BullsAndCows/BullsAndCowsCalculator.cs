namespace BullsAndCows
{
    public class BullsAndCowsCalculator
    {
        private readonly int actualNumber;

        public BullsAndCowsCalculator(int actualNumber)
        {
            this.actualNumber = actualNumber;
        }

        public BullsNCows GetBullsNCows(int givenNumber)
        {
            var digitsOfGivenNumber = NumberUtil.GetDigitListOf(givenNumber);
            var digitsOfActualNumber = NumberUtil.GetDigitListOf(actualNumber);
            var bulls = NumberUtil.CountDigitsWithSamePositionAndRemove(digitsOfGivenNumber, digitsOfActualNumber);
            var cows = digitsOfGivenNumber.FindAll(digitsOfActualNumber.Contains).Count;

            return new BullsNCows(bulls, cows);
        }
    }
}