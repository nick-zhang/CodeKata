using System.Collections.Generic;
using BullsAndCows;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BullsAndCowsTest
{
    [TestClass]
    public class NumberUtilTest
    {
        [TestMethod]
        public void ShouldReturnCorrectDigitListGivenANumber()
        {
            const int numberGiven = 1342;
            List<int> numberList = NumberUtil.GetDigitListOf(numberGiven);
            Assert.AreEqual(1, numberList[0]);
            Assert.AreEqual(3, numberList[1]);
            Assert.AreEqual(4, numberList[2]);
            Assert.AreEqual(2, numberList[3]);
        }

        [TestMethod]
        public void ShouldGenerateFourDigitalNumberWithAllDigitsAreDifferent()
        {
            int number = NumberUtil.GetFourDigitNumber();
            List<int> digitList = NumberUtil.GetDigitListOf(number);
            Assert.AreEqual(4, digitList.Count);
            Assert.AreNotEqual(digitList[0], digitList[1]);
            Assert.AreNotEqual(digitList[1], digitList[2]);
            Assert.AreNotEqual(digitList[2], digitList[3]);
        }

        
    }
}