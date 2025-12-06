using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day6
{
    public static class Day6Puzzle
    {
        public static long Run(string path)
        {
            long tot = 0;
            var lines = File.ReadLines(path).ToArray();
            
            var nums1 = GetNumbers(lines[0]);
            var nums2 = GetNumbers(lines[1]);
            var nums3 = GetNumbers(lines[2]);
            var nums4 = GetNumbers(lines[3]);
            var operators = GetOperators(lines[4]);
            for (int i = 0; i < nums1.Count; i++)
            {
                if (operators[i] == "*")
                    tot += nums1[i] * nums2[i] * nums3[i] * nums4[i];
                if (operators[i] == "+")
                    tot += nums1[i] + nums2[i] + nums3[i] + nums4[i];
            }
            return tot;
        }
        public static List<long> GetNumbers(string line)
        {
            return Regex.Matches(line, @"\d+")
                   .Select(m => long.Parse(m.Value))
                   .ToList();
        }
        public static List<string> GetOperators(string line)
        {
            return Regex.Matches(line, @"[+*]")
                   .Select(m => m.Value)
                   .ToList();
        }
    }
}
