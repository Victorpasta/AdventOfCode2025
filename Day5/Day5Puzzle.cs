using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public static class Day5Puzzle
    {
        public static int Run(string path)
        {
            var numFresh = 0;
            var lines = File.ReadLines(path);
            List<string> database = [];
            List<string> data = [];
            bool isAddingToDatabase = true;
            foreach (string line in lines)
            {
                if (string.IsNullOrEmpty(line))
                {
                    isAddingToDatabase = false;
                    continue;
                }

                if (isAddingToDatabase)
                    database.Add(line);
                else
                    data.Add(line);

            }
            var sortedData = SortDatabaseService.SortByLower(database);
            FreshnessDetector freshnessDetector = new(sortedData);
            foreach (string line in data)
            {
                if (freshnessDetector.IdIsFresh(line))
                    numFresh++;
            }
            return numFresh;
        }
        public static long RunPart2(string path)
        {
            var lines = File.ReadLines(path);
            List<string> database = [];
            foreach (string line in lines)
            {
                if (string.IsNullOrEmpty(line))
                    break;
                database.Add(line);
            }
            var sortedData = SortDatabaseService.SortByLower(database);
            FreshnessDetector freshnessDetector = new(sortedData);
            return freshnessDetector.GetNbrOfFreshIds();
        }
    }
}
