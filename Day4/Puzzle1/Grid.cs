using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Puzzle1
{
    public class Grid
    {

        public GridItem[][] GridMatrix { get; set; }
        private int XMax;
        private int YMax;
        public Grid(GridItem[][] gridMatrix, int xMax, int yMax)
        {
            GridMatrix = gridMatrix;
            XMax = xMax;
            YMax = yMax;
        }
        public int getNumberOfPapers()
        {
            var nbrPapers = 0;
            foreach (var row in GridMatrix)
            {
                foreach (var item in row)
                {
                    if (CheckIfAccesible(item))
                    {
                        item.willBeRemoved = true;
                        nbrPapers++;
                    }
                }
            }
                
            /*
            for (int i = 0; i <= YMax; i++)
            {
                for (int j = 0; j <= XMax; j++)
                {
                    if (CheckIfAccesible(GridMatrix[i][j]) == true)
                    {
                        nbrPapers++;
                    }
                }
            }
            */
            return nbrPapers;
            
        }
        public bool CheckIfAccesible(GridItem item)
        {
            int[][] adjacentItems;
            var nbrAdjacent = 0;
            if (item.HasPaper == false)
            {
                return false;
            }
            else
            {
                adjacentItems = item.GetValidAdjacent();
                for (int i = 0; i < adjacentItems.Length; i++)
                {
                    
                    for (int j = 0; j < adjacentItems[i].Length - 1; j++)
                    {
                        var X = adjacentItems[i][j + 1];
                        var Y = adjacentItems[i][j];
                        if (GridMatrix[Y][X].HasPaper == true) 
                        {
                            nbrAdjacent++;
                        }
                    }
                    
                }
                if (nbrAdjacent >= 4)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            

        }
    }
}
