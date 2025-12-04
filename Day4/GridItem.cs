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
            List<(int,int)> result = new List<(int,int)> ();
            for (int y = -1; y < 2; y++)
            {
                for(int x = -1; x < 2; x++)
                {
                    if(IsValidPosition(X + x, Y + y))
                        result.Add((X + x, Y + y));
                }
            }
            return result;
        }
        private bool IsValidPosition(int x, int y)
        {
            if (x == X && y == Y)
                return false;
            if(x > _boundries.XMax || y > _boundries.YMax)
                return false;
            if(x < 0 || y < 0) 
                return false;
            return true;
        }
    }
}
