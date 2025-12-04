using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public static class GridReader
    {
        public static Grid GetGrid(string path)
        {
            var lines = File.ReadLines(path);
            int yMax = lines.Count() - 1;
            int xMax = lines.First().Length - 1;
            var boundries = new GridBoundries(xMax, yMax);
            return new Grid(GetGridItems(lines.ToArray(), boundries), xMax, yMax);
        }
        private static GridItem[][] GetGridItems(string[] lines, GridBoundries boundries)
        {
            List<GridItem[]> matrix = [];
            int y = 0;
            foreach (var line in lines)
            {
                int x = 0;
                List<GridItem> row = [];
                foreach (char c in line)
                {
                    var gridItem = new GridItem(c == '@', x, y, boundries);
                    row.Add(gridItem);
                    x++;
                }
                matrix.Add(row.ToArray());
                y++;
            }
            return matrix.ToArray();

        }
    }
}
