using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day6
{
    public class ReadData1
    {

        public ReadData1(string path)
        {
            var lines = File.ReadLines(path);
            Grid = RemoveEmptyStrings(lines.ToList());
        }
        public List<List<string>> Grid { get; set; }
        public List<List<string>> RemoveEmptyStrings(List<string> lines)
        {
            List<List<string>> grid = [];
            string rowNumber = "";
            for (int i = 0; i < lines.Count() - 1; i++)
            {

                grid.Add(Regex.Matches(lines[i], @"\d+").Select(m => m.Value.ToString()).ToList());
            }
            var Operators = Regex.Matches(lines.Last(), @"[\*\+]");
            grid.Add(Operators.Select(m => m.Value.ToString()).ToList());
            return grid;
        }
        public long sumAllRows()
        {
            long total = 0;
            long previous = 1;
            long temp = 1;
            long a = 0;
            var b = false;
            for (int i = 0; i < Grid[0].Count(); i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (Grid[Grid.Count() - 1][i] == "+" && j < Grid.Count() - 1)
                    {
                        total += long.Parse(Grid[j][i]);
                        a += long.Parse(Grid[j][i]);
                    }
                    else if (j < Grid.Count() - 1)
                    {
                        temp *= long.Parse(Grid[j][i]);
                        b = true;
                    }
                }
                if (b)
                {
                    total += temp;
                    temp = 1;
                }
                b = false;

            }
            return total;
        }
    }
}
