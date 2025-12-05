using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public class RangeChecker
    {
        private IngridientID[] IngridientIDs;
        private IdRange[] IdRanges;
        private long[] FreshIdRange;
        public RangeChecker(IngridientID[] ingridientIds, IdRange[] idRanges) 
        {
            this.IngridientIDs = ingridientIds;
            this.IdRanges = idRanges;
           
        }
        

        public void checkIfFresh()
        {
            foreach(var id in IngridientIDs)
            {
                foreach (var idRange in IdRanges)
                {
                    if (idRange.RangeMin <= id.Id && id.Id <= idRange.RangeMax && id.IsFresh == false)
                    {
                        id.IsFresh = true;
                    }
                }
            }
        }
        public long NbrOfFreshIds()
        {
            long total = 0;
            foreach(var id in IngridientIDs)
            {
                if (id.IsFresh)
                {
                    total++;
                }
            }
            return total;
        }
    }
}
