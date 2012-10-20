using BullsAndCows;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BullsAndCowsTest
{
    [TestClass]
    public class DigitListGeneratorTest
    {
        [TestMethod]
        public void ShouldReturnCorrectDigitListGivenANumber()
        {
            const int numberGiven = 1342;
            var numberList = DigitListGenerator.GetDigitListOf(numberGiven);
            Assert.AreEqual(1, numberList[0]);
            Assert.AreEqual(3, numberList[1]);
            Assert.AreEqual(4, numberList[2]);
            Assert.AreEqual(2, numberList[3]);
        }
    }
}
