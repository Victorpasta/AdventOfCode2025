using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Puzzle2
{
    public class Puzzle2 : Day1Puzzle
    {
        public Puzzle2(int start, string inputPath) : base(start, inputPath)
        {
        }

        public override int Run()
        {
            int nbrOfZeroes = 0;
            var lines = File.ReadLines(_inputPath);
            foreach (var line in lines)
            {
                bool isIncreasing = line.StartsWith("R");
                bool startedAtZero = _current == 0;
                var total = CalculateTotal(line, isIncreasing, _current);
                nbrOfZeroes += EvaluateTotal(total, startedAtZero);
                _current = Mod(total, 100);

            }
            return nbrOfZeroes;
        }

        private int EvaluateTotal(int total, bool startedAtZero)
        {
            var rotations = Math.Abs(total / 100);
            if (total <= 0)
            {
                var nbrOfZeroes = rotations + 1;
                if (startedAtZero)
                    nbrOfZeroes -= 1;
                return nbrOfZeroes;
            }
            return rotations;

        }
    }
}
