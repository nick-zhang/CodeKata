using BullsAndCows;
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
}
