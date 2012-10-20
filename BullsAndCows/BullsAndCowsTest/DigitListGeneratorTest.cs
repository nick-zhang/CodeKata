using System.Collections.Generic;
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

    public class DigitListGenerator
    {
        public static List<int> GetDigitListOf(int numberGiven)
        {
            var a = numberGiven / 1000;
            var b = (numberGiven - a * 1000) / 100;
            var c = (numberGiven - a * 1000 - b * 100) / 10;
            var d = numberGiven % 10;

            return new List<int> {a, b, c, d};
        }
    }
}
