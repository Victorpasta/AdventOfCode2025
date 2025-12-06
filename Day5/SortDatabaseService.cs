using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public static class SortDatabaseService
    {
        public static List<string> SortByLower(List<string> rawInput)
        {
            return rawInput
                .OrderBy(x => long.Parse(x.Split("-")[0]))
                .ToList();
        }

        public static List<string> CreatePart2List(List<string> sortedByLower)
        {
            var newList = new List<string>();
            
            string prevRange = sortedByLower.First();
            sortedByLower.RemoveAt(0);
            while (sortedByLower.Count > 0)
            {
                var prevUpper = IdRangeUtils.GetUpperLong(prevRange);
                var currentRange = sortedByLower.First();
                var currentLower = IdRangeUtils.GetLowerLong(currentRange);
                var currentUpper = IdRangeUtils.GetUpperLong(currentRange);

                if (currentLower <= prevUpper)
                {
                    if (currentUpper >= prevUpper)
                        prevRange = IdRangeUtils.SetUpperString(currentUpper.ToString(), prevRange);
                    sortedByLower.RemoveAt(0);

                }
                else if(currentLower > prevUpper)
                {
                    newList.Add(prevRange);
                    sortedByLower.RemoveAt(0);
                    prevRange = currentRange;
                }
                if (sortedByLower.Count == 0)
                    newList.Add(prevRange);
            }
           
            return newList;
        }

    }
}
