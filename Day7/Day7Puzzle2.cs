using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public  class Day7Puzzle2
    {
        public static Dictionary<Splitter, long> Cache = [];
        public static long Run(string path)
        {
            var lines = File.ReadLines(path);
            List<Splitter> splitters = [];
            var indexesToCheck = new HashSet<int>();
            var firstIndex = lines.First().IndexOf("S");
            indexesToCheck.Add(firstIndex);
            int i = 1;
            foreach (var line in lines.Skip(1))
            {
                HashSet<int> indexesToRemove = [];
                HashSet<int> indexesToAdd = [];
                foreach (var index in indexesToCheck)
                {
                    if (index > 0 && line[index] == '^')
                    {
                        indexesToRemove.Add(index);
                        splitters.Add(new(index, i));
                        indexesToAdd.Add(index - 1);
                        indexesToAdd.Add(index + 1);
                    }
                }
                foreach (var index in indexesToAdd)
                    indexesToCheck.Add(index);
                foreach (var index in indexesToRemove)
                    indexesToCheck.Remove(index);
                i++;
            }
            return splitters.First().GetNumberOfDirectPathsDown(splitters);
           
        }
    }
}
