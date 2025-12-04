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
           
        }
        public GridItem GetItem(int x, int y) => GridMatrix[x][y];
    }
}
