using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BullsAndCowsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldReturnCorrectNumberOfBulls()
        {
            const int numberGiven = 1234;
            const int actualNumber = 1567;
            var bullsAndCowsCalaulator = new BullsAndCowsCalaulator(actualNumber);
            var bulls = bullsAndCowsCalaulator.CalculateBulls(numberGiven);
            Assert.AreEqual(1, bulls);
        }
    }

    public class BullsAndCowsCalaulator
    {
        public BullsAndCowsCalaulator(int actualNumber)
        {
            throw new System.NotImplementedException();
        }

        public int CalculateBulls(int numberGiven)
        {
            throw new System.NotImplementedException();
        }
    }
}
