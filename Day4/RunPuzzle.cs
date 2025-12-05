using Day4.Puzzle1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public class RunPuzzle
    {
        private string path;
        public RunPuzzle(string path) {
            this.path = path;
        }
        private int Run(Grid grid)
        {
            var total = grid.getNumberOfPapers();
            return total;
        }
        public int RunOnce()
        {
            Grid grid = GridReader.GetGrid(path);
            return Run(grid);
            
        }
        public int MultipleRuns()
        {
            Grid grid = GridReader.GetGrid(path);
            var current = Run(grid);
            var total = 0;
            while (current > 0)
            {
                foreach (var row in grid.GridMatrix)
                {
                    foreach (var item in row)
                    {
                        if (item.willBeRemoved)
                        {
                            item.HasPaper = false;
                        }
                    }
                }
                total += current;
                current = Run(grid);
            }
            return total;

        }
    }
}
