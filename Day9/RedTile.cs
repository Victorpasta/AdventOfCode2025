using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    public class RedTile(long x, long y)
    {
        public List<(RedTile Tile, long Area)> SortedTilesAndAreas { get; set; }
        public long X { get; } = x;
        public long Y { get; } = y;
        public long GetAreaWithOtherTile(RedTile otherTile)
        {
            var width = Math.Abs(X - otherTile.X) + 1;
            var height = Math.Abs(Y - otherTile.Y) + 1;
            return width * height;
        }
        public void OrderBoxes(RedTile[] tiles)
        {
            SortedTilesAndAreas = tiles.OrderBy(t => GetAreaWithOtherTile(t)).Select(t => (t, GetAreaWithOtherTile(t))).Reverse()
                .ToList();
        }
        public string ToString()
        {
            return SortedTilesAndAreas.First().Area.ToString();
        }
    }
}
