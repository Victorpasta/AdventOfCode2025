using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    public class SearchGrid
    {
        public double X { get; }
        public double Y { get; }
        public double Z { get; }
        public double Size { get; }
        public JunctionBox[] BoxesInGrid { get; set; }

        public SearchGrid(double x, double y, double z, double size, JunctionBox[] allBoxes)
        {
            X = x;
            Y = y;
            Z = z;
            Size = size;
            BoxesInGrid = GetJunctionBoxesInside(allBoxes);
        }

        public JunctionBox[] GetJunctionBoxesInside(JunctionBox[] allBoxes)
        {

            return allBoxes.Where(jb => jb.IsInsideGrid(this)).ToArray();
        }
        public SearchGrid[] GetMooreNeighborhood(SearchGrid[] searchGrids)
        {
            var neighbors = new List<SearchGrid>();
            for (double dx = -Size; dx <= Size; dx += Size)
            {
                for (double dy = -Size; dy <= Size; dy += Size)
                {
                    for (double dz = -Size; dz <= Size; dz += Size)
                    {
                        // Skip the center point itself
                        if (dx == 0 && dy == 0 && dz == 0)
                            continue;
                        var neighbor = searchGrids.FirstOrDefault(sg => sg.X == (X + dx) && sg.Y == (Y + dy) && sg.Z == (Z + dz));
                        if (neighbor == null)
                            continue;
                        neighbors.Add(neighbor);
                    }
                }
            }
            neighbors.Add(this);
            return neighbors.ToArray();
        }
    }
}
