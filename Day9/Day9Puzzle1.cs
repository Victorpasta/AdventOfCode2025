namespace Day9
{
    public class Day9Puzzle1
    {
        public static long Run(string path)
        {
            List<RedTile> tiles = [];
            var lines = File.ReadLines(path);
            foreach (var line in lines)
            {
                var x = line.Split(",")[0];
                var y = line.Split(",")[1];
                tiles.Add(new(long.Parse(x), long.Parse(y)));
            }
            foreach (var tile in tiles)
                tile.OrderBoxes(tiles.ToArray());
            List<RedTile> sortedTiles = tiles.OrderBy(jb => jb.SortedTilesAndAreas.First().Area).Reverse().ToList();
            var furthestTile = sortedTiles.First();
            var t = sortedTiles.Last();
            return furthestTile.SortedTilesAndAreas.First().Area;
        }
        public static long Run2(string path)
        {
            List<RedTile> tiles = [];
            var lines = File.ReadLines(path);
            foreach (var line in lines)
            {
                var x = line.Split(",")[0];
                var y = line.Split(",")[1];
                tiles.Add(new(long.Parse(x), long.Parse(y)));
            }
            foreach (var tile in tiles)
                tile.OrderBoxes(tiles.ToArray());
            
            bool furthestTileFound = false;
            while (!furthestTileFound)
            {
                List<RedTile> sortedTiles = tiles.OrderBy(jb => jb.SortedTilesAndAreas.First().Area).Reverse().ToList();
                var furthestTile = sortedTiles.First();
                var opositeCorner = furthestTile.SortedTilesAndAreas[0].Tile;
                bool xIncreases = opositeCorner.X > furthestTile.X;
                bool yIncreases = opositeCorner.Y > furthestTile.Y;

                if (!xIncreases)
                {
                    var temp = furthestTile;
                    furthestTile = opositeCorner;
                    opositeCorner = temp;
                }
                var current = furthestTile;

            }

        }

    }
}
