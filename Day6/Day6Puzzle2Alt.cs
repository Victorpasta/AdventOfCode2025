using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day6
{
    public class Day6Puzzle2Alt
    {
        public static long Run(string path)
        {
            long tot = 0;
            var lines = File.ReadLines(path).ToList();
            //lines = lines.Select(s => s + "  ").ToList();
            int i = 0;
            var operation = lines.Last()[i];
            long numberToAdd = operation == '*' ? 1 : 0;
            var length = lines.First().Length;
            while (i < length)
            {
                if (lines.All(l => l[i] == ' '))
                {
                    tot += numberToAdd;
                    operation = lines.Last()[i+1];
                    numberToAdd = operation == '*' ? 1 : 0;
                    i++;
                    continue;
                }
                var cephalopodNumberStr = "";
                foreach (var line in lines.SkipLast(1))
                {
                    var digit = line[i].ToString();
                    if (digit == " ")
                        digit = "";
                    cephalopodNumberStr += digit;
                }
                long cephalopodNumber = long.Parse(cephalopodNumberStr);
                if (operation == '*')
                    numberToAdd = cephalopodNumber * numberToAdd;

                if (operation == '+')
                    numberToAdd = cephalopodNumber + numberToAdd;
                i++;
                if(i == length)
                    tot += numberToAdd;
            }
            return tot;
        }
        
    }
}
