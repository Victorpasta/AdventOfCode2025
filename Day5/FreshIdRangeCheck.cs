using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public class FreshIdRangeCheck
    {
        private long[] FreshIdArray;
        private IdRange[] IdRanges;
        public FreshIdRangeCheck(IdRange[] idRanges)
        {
            IdRanges = idRanges;
            FreshIdArray = [];
        }
        public void InsertionSort()
        {
            for( int i = 1; i < IdRanges.Length; i++)
            {
                long key = IdRanges[i].RangeMin;
                int j = i - 1;

                while (j >= 0 && IdRanges[j].RangeMin > key)
                {
                    var temp = IdRanges[j + 1];
                    IdRanges[j + 1] = IdRanges[j];
                    IdRanges[j] = temp;
                    j = j - 1;
                }
                IdRanges[j + 1].RangeMin = key;
            }
        }

        public long GetFreshIDs()
        {
            var lowerBound = IdRanges[0].RangeMin;
            var upperBound = IdRanges[0].RangeMax;
            long count = 0;

            for(int i = 1; i < IdRanges.Length; i++)
            {
                
                if (IdRanges[i].RangeMin <= upperBound + 1)
                {
                    upperBound = Math.Max(upperBound, IdRanges[i].RangeMax);
                }
                else
                {
                    count += (upperBound - lowerBound + 1);
                    lowerBound = IdRanges[i].RangeMin;
                    upperBound = IdRanges[i].RangeMax;

                }
                

            }
            count += (upperBound - lowerBound + 1);
            return count;
           


         
        }

    }
}
