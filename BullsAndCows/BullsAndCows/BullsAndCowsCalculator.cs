namespace BullsAndCows
{
    public class BullsAndCowsCalculator
    {
        private readonly int actualNumber;

        public BullsAndCowsCalculator(int actualNumber)
        {
            this.actualNumber = actualNumber;
        }

        public int GetBulls(int givenNumber)
        {
            var digitsOfGivenNumber = DigitListGenerator.GetDigitListOf(givenNumber);
            var digitsOfActualNumber = DigitListGenerator.GetDigitListOf(actualNumber);
            return DigitListGenerator.CountDigitsWithSamePositionAndRemove(digitsOfGivenNumber, digitsOfActualNumber);
        }

        public int GetCows(int givenNumber)
        {
            var digitsOfGivenNumber = DigitListGenerator.GetDigitListOf(givenNumber);
            var digitsOfActualNumber = DigitListGenerator.GetDigitListOf(actualNumber);
            DigitListGenerator.CountDigitsWithSamePositionAndRemove(digitsOfGivenNumber, digitsOfActualNumber);
            return digitsOfGivenNumber.FindAll(digitsOfActualNumber.Contains).Count;
        }
    }
}