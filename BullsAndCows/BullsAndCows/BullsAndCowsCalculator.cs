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
            var digitsOfGivenNumber = DigitListGenerator.GetDigitListOf(givenNumber);
            var digitsOfActualNumber = DigitListGenerator.GetDigitListOf(actualNumber);
            var bulls = DigitListGenerator.CountDigitsWithSamePositionAndRemove(digitsOfGivenNumber, digitsOfActualNumber);
            var cows = digitsOfGivenNumber.FindAll(digitsOfActualNumber.Contains).Count;

            return new BullsNCows(bulls, cows);
        }
    }
}