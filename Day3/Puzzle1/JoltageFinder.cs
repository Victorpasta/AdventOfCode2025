using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Puzzle1
{
    public static class JoltageFinder
    {
        public static long FindMaximumJoltage(string line, int nbrOfBatteries)
        {
            var resString = "";
            var nextSearchSpace = line.Substring(0, line.Length - nbrOfBatteries + 1);
            var startIndex = 0;
            for (int i = 1; i <= nbrOfBatteries; i++)
            {

                string digitI = FindHighestDigit(nextSearchSpace, out int indexOfDigitI).ToString();
                startIndex = indexOfDigitI + startIndex + 1;
                var end = line.Length - (nbrOfBatteries - i - 1);
                if (end > line.Length)
                    nextSearchSpace = line.Substring(startIndex);
                else
                    nextSearchSpace = line.Substring(startIndex, end - startIndex);
                resString += digitI;
            }
            return long.Parse(resString);
        }
        public static long FindHighestDigit(string input, out int index)
        {
            var highest = 0;
            var current = 0;
            var i = 0;
            index = -1;
            foreach (char c in input)
            {
                current = c - '0';
                if (current > highest)
                {
                    highest = current;
                    index = i;
                }
                i++;
            }
            return highest;
        }
    }
}
