using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day2.Puzzle1
{
    public class Day2Range
    {
        private readonly long _start;
        private readonly long _end;
        private readonly IdIsInvalidStrategy _strat;

        public long[] InvalidIds { get; }

        public Day2Range(long start, long end, IdIsInvalidStrategy strat) 
        {
            _start = start;
            _end = end;
            _strat = strat;
            InvalidIds = FindInvalidIds();
        }
        public long[] FindInvalidIds()
        {
            List<long> invalidIds = [];
            var current = _start;
            while (current <= _end)
            {
                if(_strat.IdIsInvalid(current.ToString()))
                    invalidIds.Add(current);
                current++;
            }
            return invalidIds.ToArray();
        }
       
    }
}
