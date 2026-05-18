using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    public class JunctionBox
    {
        public List<(JunctionBox Box, double Distance)> SortedBoxesAndDistance { get; set; }

        public JunctionBox(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double X { get; }
        public double Y { get; }
        public double Z { get; }

        public double GetDistanceToOtherBox(JunctionBox otherBox)
        {
            var xSq = Math.Pow((X - otherBox.X),2);
            var ySq = Math.Pow((Y - otherBox.Y),2);
            var zSq = Math.Pow((Z - otherBox.Z),2);
            return Math.Sqrt(xSq + ySq + zSq);
        }
        public JunctionBox FindClosestBoxDistance(JunctionBox[] junctionBoxes, out double distance)
        {
            distance = double.MaxValue;
            JunctionBox best = null;
            foreach (var other in junctionBoxes)
            {
                if (other == this)
                    continue;
                var next = GetDistanceToOtherBox(other);
                if (next < distance)
                {
                    best = other;
                    distance = next;
                }
            }
            return best;
        }
        public bool IsInsideGrid(SearchGrid grid)
        {
            if(grid.X+grid.Size > X || grid.X < X)
                return false;
            if (grid.Y + grid.Size > Y || grid.Y < Y)
                return false;
            if (grid.Z + grid.Size > Z || grid.Z < Z)
                return false;
            return true;
        }

        public void OrderBoxes(JunctionBox[] boxes)

        {
            SortedBoxesAndDistance = boxes.OrderBy(jb => GetDistanceToOtherBox(jb)).Select(jb => (jb, GetDistanceToOtherBox(jb)))
                .ToList();
            SortedBoxesAndDistance.RemoveAt(0);
        }
    }
}
