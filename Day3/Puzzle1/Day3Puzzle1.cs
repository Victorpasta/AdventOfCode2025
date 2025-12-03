using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Puzzle1
{
    public class Day3Puzzle1
    {
        public static long Run(string path, int nbrOfBatteries)
        {
            long tot = 0;
            var lines = File.ReadLines(path);
            foreach (var line in lines)
                tot += JoltageFinder.FindMaximumJoltage(line, nbrOfBatteries);
            return tot;
        }
    }
}
