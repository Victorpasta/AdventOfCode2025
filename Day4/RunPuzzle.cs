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
        public int Run()
        {
            Grid grid = GridReader.GetGrid(path);
            var total = grid.getNumberOfPapers();
            return total;
        }
      

        
    }
}
