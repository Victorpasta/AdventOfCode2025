using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    public abstract class Day1Puzzle
    {
        protected int _current;
        protected readonly string _inputPath;

        public Day1Puzzle(int start, string inputPath)
        {
            _current = start;
            _inputPath = inputPath;
        }
        public abstract int Run();
        protected int CalculateTotal(string line, bool isIncreasing, int current)
        {
            int.TryParse(line.Substring(1), out int number);
            if (isIncreasing)
                return current + number;
            else
                return current - number;
        }
        public static int Mod(int a, int b)
        {
            return ((a % b) + b) % b;
        }
    }
}
