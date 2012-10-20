using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BullsAndCowsTest
{
    [TestClass]
    public class BullsAndCowsCalculatorTest
    {
        [TestMethod]
        public void ShouldReturnCorretNumberOfBulls()
        {
            const int givenNumber = 1234;
            const int actualNumber = 1678;
            var bullsAndCowsCalculator = new BullsAndCowsCalculator(actualNumber);
            var bulls = bullsAndCowsCalculator.GetBulls(givenNumber);
            Assert.AreEqual(1, bulls);
        }

        [TestMethod]
        public void ShouldReturnCorretNumberOfCows()
        {
            const int givenNumber = 1234;
            const int actualNumber = 1678;
            var bullsAndCowsCalculator = new BullsAndCowsCalculator(actualNumber);
            var cows = bullsAndCowsCalculator.GetCows(givenNumber);
            Assert.AreEqual(0, cows);
        }
    }

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
            return CountDigitsWithSamePositionAndRemove(digitsOfGivenNumber, digitsOfActualNumber);
        }

        private static int CountDigitsWithSamePositionAndRemove(IList digitsOfGivenNumber, IList digitsOfActualNumber)
        {
            var bulls = 0;
            for (var i = 0; i < digitsOfActualNumber.Count; i++)
            {
                if (digitsOfActualNumber[i].Equals(digitsOfGivenNumber[i]))
                {
                    bulls++;
                    digitsOfActualNumber.RemoveAt(i);
                    digitsOfGivenNumber.RemoveAt(i);
                }
            }
            return bulls;
        }

        public int GetCows(int givenNumber)
        {
            var digitsOfGivenNumber = DigitListGenerator.GetDigitListOf(givenNumber);
            var digitsOfActualNumber = DigitListGenerator.GetDigitListOf(actualNumber);
            CountDigitsWithSamePositionAndRemove(digitsOfGivenNumber, digitsOfActualNumber);
            return digitsOfGivenNumber.FindAll(digitsOfActualNumber.Contains).Count;
        }
    }
}
