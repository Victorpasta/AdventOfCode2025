using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Puzzle1
{
    public static class RangeFinder
    {
        public static Day2Range[] FindInFile(string path, IdIsInvalidStrategy strat)
        {
            List<Day2Range> ranges = [];
            //Should be only one line
            var line = File.ReadLines(path).First();
            var rangeStrings = line.Split(",");
            foreach(var rangeString in rangeStrings)
                ranges.Add(CreateRangeFromString(rangeString, strat));
            return ranges.ToArray();
        }
        private static Day2Range CreateRangeFromString(string rangeString, IdIsInvalidStrategy strat)
        {
            var edges = rangeString.Split("-");
            var start = long.Parse(edges[0]);
            var end = long.Parse(edges[1]);
            return new Day2Range(start, end, strat);
        }
    }
}
