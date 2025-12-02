using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Puzzle1
{
    public class Puzzle3Victor
    {
        public static long Run(string path, IdIsInvalidStrategy strat)
        {
            var ranges = RangeFinder.FindInFile(path,strat);
            long sum = 0;
            foreach(var range in ranges)
                sum += range.InvalidIds.Sum();
            return sum;
        }
    }
}
