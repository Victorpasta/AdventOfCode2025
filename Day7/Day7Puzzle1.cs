
namespace Day7
{
    public static class Day7Puzzle1
    {
        public static int Run(string path)
        {
            var splits = 0;
            var lines = File.ReadLines(path);
            var indexesToCheck = new HashSet<int>();
            var firstIndex = lines.First().IndexOf("S");
            indexesToCheck.Add(firstIndex);
            foreach (var line in lines.Skip(1))
            {
                HashSet<int> indexesToRemove = [];
                HashSet<int> indexesToAdd = [];
                foreach (var index in indexesToCheck)
                {
                    if (index > 0 && line[index] == '^')
                    {
                        indexesToRemove.Add(index);
                        indexesToAdd.Add(index - 1);
                        indexesToAdd.Add(index + 1);
                        splits++;
                    }
                }
                foreach (var index in indexesToAdd)
                    indexesToCheck.Add(index);
                foreach (var index in indexesToRemove)
                    indexesToCheck.Remove(index);
            }
            return splits;
        }
        
    }
}
