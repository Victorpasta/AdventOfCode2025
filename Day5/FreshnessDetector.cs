using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public class FreshnessDetector
    {
        public static bool IsPart2 = false;
        public FreshnessDetector(List<string> sortedData)
        {
            SortedByLower = sortedData;
            Part2List = SortDatabaseService.CreatePart2List(SortedByLower);
             
        }

        public List<string> SortedByLower { get; private set; }
        public List<string> Part2List { get; private set; }

        public bool IdIsFresh(string id)
        {
            foreach (var range in SortedByLower)
            {
                var lower = IdRangeUtils.GetLowerLong(range);
                var upper = IdRangeUtils.GetUpperLong(range);
                var idLong = long.Parse(id);
                if (lower > idLong)
                    return false;
                if (idLong >= lower && idLong <= upper)
                    return true;
            }
            return false;
        }

        public long GetNbrOfFreshIds()
        {
            long tot = 0;
            foreach(var range in Part2List)
            {
                var lower = IdRangeUtils.GetLowerLong(range);
                var upper = IdRangeUtils.GetUpperLong(range) + 1;
                tot += upper - lower;
            }
            return tot;
        }
        
    }
}
