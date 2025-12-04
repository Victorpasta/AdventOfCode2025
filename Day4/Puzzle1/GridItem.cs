using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Puzzle1
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
        public int X { get; }
        public int Y { get; }

        public int[][] GetValidAdjacent()
        {
            var list = new List<int[]>();
            for (int i = -1; i < 2; i++)
            {   
               
                for (int j = -1; j < 2; j++)
                {   
                    var xy = new List<int> ();
                    
                    if (CheckBoundsValid(Y + i, X + j) == true)
                    {
                        xy.Add(Y + i);
                        xy.Add(X + j);
                        list.Add(xy.ToArray());
                    }

                }
            }
            return list.ToArray();

        }
        public bool CheckBoundsValid(int y, int x)
        {
            int yMax = _boundries.YMax;
            int xMax = _boundries.XMax;

            if (x > xMax || y > xMax)
            {
                return false;
            }
            if (y == X && x == X)
            {
                return false;
            }
            if (y < 0 || x < 0)
            {
                return false;
            }
            return true;
        }

    }
}
