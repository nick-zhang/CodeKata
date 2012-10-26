using System;
using System.Collections;
using System.Collections.Generic;

namespace BullsAndCows
{
    public class NumberUtil
    {
        public static List<int> GetDigitListOf(int numberGiven)
        {
            var a = numberGiven / 1000;
            var b = (numberGiven - a * 1000) / 100;
            var c = (numberGiven - a * 1000 - b * 100) / 10;
            var d = numberGiven % 10;

            return new List<int> {a, b, c, d};
        }

        public static int CountDigitsWithSamePositionAndRemove(IList digitsOfGivenNumber, IList digitsOfActualNumber)
        {
            var digitsWithSamePositionCount = 0;
            for (var i = 0; i < digitsOfActualNumber.Count; i++)
            {
                if (digitsOfActualNumber[i].Equals(digitsOfGivenNumber[i]))
                {
                    digitsWithSamePositionCount++;
                    digitsOfActualNumber.RemoveAt(i);
                    digitsOfGivenNumber.RemoveAt(i);
                }
            }
            return digitsWithSamePositionCount;
        }

        public static int GetFourDigitNumber()
        {
            var nums = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            KnuthShuffle(ref nums);
            var chosenNum = new int[4];
            Array.Copy(nums, chosenNum, 4);

            return chosenNum[0]*1000 + chosenNum[1]*100 + chosenNum[2]*10 + chosenNum[3];
        }

        private static void KnuthShuffle<T>(ref T[] array)
        {
            var random = new Random();
            for (var i = 0; i < array.Length; i++)
            {
                var j = random.Next(array.Length);
                var temp = array[i]; array[i] = array[j]; array[j] = temp;
            }
        }
    }
}