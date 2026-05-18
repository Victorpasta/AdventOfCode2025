using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    public static class CreateJunctionBoxesService
    {
        public static JunctionBox[] CreateJunctionBoxes(string path)
        {
            List<JunctionBox> junctionBoxes = [];
            var lines = File.ReadLines(path);
            foreach (var line in lines)
            {
                var coords = line.Split(",");
                int x = int.Parse(coords[0]);
                int y = int.Parse(coords[1]);
                int z = int.Parse(coords[2]);
                junctionBoxes.Add(new(x, y, z));
            }
            return junctionBoxes.ToArray();
        }
    }
}
