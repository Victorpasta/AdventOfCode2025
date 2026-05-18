using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    public class SearchSpace
    {
        public SearchGrid[] Grids { get; set; }
        private double _gridSize;
        public SearchSpace(JunctionBox[] boxes, double d)
        {
            _gridSize = d / (2 * Math.Sqrt(3));
            Grids = GetSearchGrids(boxes);

        }
        public SearchGrid[] GetSearchGrids(JunctionBox[] boxes)
        {
            List<SearchGrid> grids = [];
            double xMax = double.MinValue;
            double yMax = double.MinValue;
            double zMax = double.MinValue;
            double xMin = double.MaxValue;
            double yMin = double.MaxValue;
            double zMin = double.MaxValue;
            foreach (var box in boxes)
            {
                if (box.X < xMin)
                    xMin = box.X;
                if (box.Y < yMin)
                    yMin = box.Y;
                if (box.Z < zMin)
                    zMin = box.Z;
                if (box.X > xMax)
                    xMax = box.X;
                if (box.Y > yMax)
                    yMax = box.Y;
                if (box.Z > zMax)
                    zMax = box.Z;
            }
            double currentX = xMin;
            double currentY = yMin;
            double currentZ = zMin;
            while (currentZ < zMax)
            {
                while (currentY < yMax)
                {
                    while (currentX < xMax)
                    {
                        grids.Add(new SearchGrid(currentX, currentY, currentZ, _gridSize, boxes));

                        currentX += _gridSize;
                    }
                    grids.Add(new SearchGrid(currentX, currentY, currentZ, _gridSize, boxes));
                    currentY += _gridSize;
                    currentX = xMin;

                }
                grids.Add(new SearchGrid(currentX, currentY, currentZ, _gridSize, boxes));
                currentZ += _gridSize;
                currentY = yMin;

            }
            return grids.ToArray();

        }
        public JunctionBox[] GetAllBoxesInSpace(JunctionBox[] allBoxes)
        {
            List<JunctionBox> boxes = [];
            foreach (var grid in Grids)
                boxes.AddRange(grid.GetJunctionBoxesInside(allBoxes));
            return boxes.ToArray();
        }


    }
}
