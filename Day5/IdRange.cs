using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public class IdRange
    {
        public IdRange(long rangeMin, long rangeMax)
        {
            this.RangeMin = rangeMin;
            this.RangeMax = rangeMax;
        }

        public long RangeMin { get; set; }
        public long RangeMax { get; set; }

    }
 

}
