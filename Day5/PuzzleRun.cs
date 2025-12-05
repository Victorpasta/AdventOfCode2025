using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public class PuzzleRun
    {
        private readonly string Path;
        public PuzzleRun(string path)
        {
            Path = path;
        }
        public long Run()
        { 
            ReadData input = new ReadData(Path);
            var ids = input.StoreIngridientID();
            var idRanges = input.StoreIdRanges();
            var rangeChecker = new RangeChecker(ids, idRanges);
            rangeChecker.checkIfFresh();
            var total = rangeChecker.NbrOfFreshIds();
            return total;
        }
        public long Run2()
        {
            ReadData input1 = new ReadData(Path);
            var idRanges = input1.StoreIdRanges();
            var freshIds = new FreshIdRangeCheck(idRanges);
            freshIds.InsertionSort();
            long total = freshIds.GetFreshIDs();
            return total;
        }
    }
}
