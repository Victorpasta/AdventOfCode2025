using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public static class Day4Puzzle
    {
        public static int RunOnce(string path, Grid grid = null)
        {
            if (grid == null)
                grid = GridReader.GetGrid(path);
            int nbrOfAccessablePapers = 0;
            foreach (var row in grid.GridMatrix)
            {
                foreach (var item in row)
                {
                    if (grid.SpaceIsAccessable(item))
                        nbrOfAccessablePapers++;
                }
            }
            return nbrOfAccessablePapers;
        }
        public static int RunMultiple(string path)
        {
            var tot = 0;
            var grid = GridReader.GetGrid(path);
            var current = RunOnce(path, grid);
            while (current > 0)
            {
                foreach (var row in grid.GridMatrix)
                {
                    foreach (var item in row)
                    {
                        if (item.ShouldBeRemoved)
                            item.HasPaper = false;
                    }
                }
                tot += current;
                current = RunOnce(path, grid);
            }
            return tot;
        }
    }
}
