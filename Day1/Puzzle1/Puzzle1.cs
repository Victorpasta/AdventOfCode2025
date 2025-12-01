using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Puzzle1
{
    public static class Puzzle1
    {
        public static int Run(string inputPath) 
        {
            int nbrOfZeroes = 0;
            int current = 50;
            var lines = File.ReadLines(inputPath);
            foreach (var line in lines)
            {
                current = CalculateResult(line, current);
                if(current == 0)
                    nbrOfZeroes++;
            }
            return nbrOfZeroes;
        }

        public static int CalculateResult(string line, int current)
        {
            bool isIncreasing = line.StartsWith("R");
            int.TryParse(line.Substring(1), out int number);
            if (isIncreasing)
                current += number;
            else
                current -= number;
            return current % 100;
        }
    }
}
