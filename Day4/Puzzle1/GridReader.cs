using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Puzzle1
{
    public static class GridReader
    {
        public static Grid GetGrid(String path)
        {
            var lines = File.ReadLines(path);
            int yMax = lines.Count() - 1;
            int xMax = lines.First().Length - 1;
            var gridBoundries = new GridBoundries(xMax, yMax);
            return new Grid(GetGridItems(lines.ToArray(), gridBoundries), xMax, yMax);
        }


        private static GridItem[][] GetGridItems(string[] lines, GridBoundries boundries)
        {
            List<GridItem[]> matrix = [];
            int y = 0;
            foreach (String line in lines)
            {
                
                var x = 0;
                List<GridItem> items = [];
                foreach(Char c in line)
                {
                    
                    if (c == '.')

                        items.Add(new GridItem(false, x, y, boundries));

                    else
                    
                        items.Add(new GridItem(true, x, y, boundries));
                    x += 1;
                }
                y += 1;
            matrix.Add(items.ToArray());
            }
            return matrix.ToArray();
        }
    }
}
