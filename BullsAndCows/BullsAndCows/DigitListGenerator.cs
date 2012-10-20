using System.Collections;
using System.Collections.Generic;

namespace BullsAndCows
{
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

        public static int CountDigitsWithSamePositionAndRemove(int givenNumber, int actualNumber)
        {
            var digitsOfGivenNumber = GetDigitListOf(givenNumber);
            var digitsOfActualNumber = GetDigitListOf(actualNumber);

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

        public static int CountDigitsWithSamePositionAndRemove(IList digitsOfGivenNumber, IList digitsOfActualNumber)
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
    }
}