using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public static class IdRangeUtils
    {
        public static long GetUpperLong(string range) => long.Parse(range.Split("-")[1]);
        public static long GetLowerLong(string range) => long.Parse(range.Split("-")[0]);
        public static string GetUpperString(string range) => range.Split("-")[1];
        public static string GetLowerString(string range) => range.Split("-")[0];
        public static string SetUpperString(string upper, string range)
        {
            var lower = range.Split("-")[0];
            return lower + "-" + upper;
        }

    }
}
