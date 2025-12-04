using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public class GridItem
    {
        private readonly GridBoundries _boundries;

        public GridItem(bool hasPaper, int x, int y, GridBoundries boundries)
        {
            HasPaper = hasPaper;
            X = x;
            Y = y;
            _boundries = boundries;
        }

        public bool HasPaper { get; set; }
        public bool ShouldBeRemoved { get; set; } = false;
        public int X { get; }
        public int Y { get; }

        public List<(int x, int y)> GetAdjacentPositions()
        {
            
        }
        private bool IsValidPosition(int x, int y)
        {
            
        }
    }
}
