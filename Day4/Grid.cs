using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public class Grid
    {
        public GridItem[][] GridMatrix {  get; set; }
        public Grid(GridItem[][] gridMatrix, int xMax, int yMax)
        {
            GridMatrix = gridMatrix;
        }
        public bool SpaceIsAccessable(GridItem item)
        {
            if(!item.HasPaper)
                return false;
            var adjacentPaperCount = 0;
            var positionsToCheck = item.GetAdjacentPositions();
            foreach (var position in positionsToCheck)
            {
                var itemToCheck = GridMatrix[position.y][position.x];
                if(itemToCheck.HasPaper)
                    adjacentPaperCount++;
                if (adjacentPaperCount == 4)
                    return false;
            }
                item.ShouldBeRemoved = true;
            return true;
        }
        public GridItem GetItem(int x, int y) => GridMatrix[x][y];
    }
}
