using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public static class Day6Puzzle2
    {
        public static long Run(string path)
        {
            var lines = File.ReadLines(path);
            long total = GetTotal(lines.ToArray());
            return total;
        }
        public static long GetTotal(string[] lines)
        {

            int i = 0;
            int length = lines[0].Count();
            var operation = lines.Last()[i];
            long numberToAdd = operation == '*' ? 1 : 0;
            var digit = "";
            long total = 0;
            var number = "";
            while (i < length)
            {
                number = "";
                if (lines.All(s => s[i] == ' '))
                {
                    total += numberToAdd;
                    operation = lines.Last()[i + 1];
                    numberToAdd = operation == '*' ? 1 : 0;
                    i++;
                    continue;
                }
                //siffror

                for (int j = 0; j < lines.Count() - 1; j++)
                {
                    digit = lines[j][i].ToString();
                    if (digit == " ")
                    {
                        digit = "";
                    }
                    number += digit;
                }
                if (operation == '*')
                {
                    numberToAdd *= long.Parse(number);
                }
                else
                {
                    numberToAdd += long.Parse(number);
                }
                i++;

            }
            total += numberToAdd;
            return total;
        }
    }
}
