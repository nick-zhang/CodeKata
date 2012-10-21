using System;

namespace BullsAndCows
{
    class Program
    {
        static void Main(string[] args)
        {
            var actualNumber = NumberUtil.GetFourDigitNumber();
            var bullsAndCowsCalculator = new BullsAndCowsCalculator(actualNumber);
            Console.WriteLine("Let's guess! Please give your number ...");

            while (true)
            {
                var readLine = Console.ReadLine();
                if (readLine != null)
                {
                    var givenNumber = int.Parse(readLine);
                    if (givenNumber != actualNumber)
                    {
                        var bullsNCows = bullsAndCowsCalculator.GetBullsNCows(givenNumber);
                        Console.WriteLine(String.Format("{0} bulls & {1} cows", bullsNCows.Bulls, bullsNCows.Cows));
                    }
                    else
                    {
                        Console.WriteLine("Congratulations! You won.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Please input valid number: 4 digits and all of them are different, such as 1345!");
                }
            }
        }
    }
}