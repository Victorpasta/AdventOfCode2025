using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public class ReadData
    {
        private string[] IDs;
        private string[] IdRanges;
        public ReadData(string path)
        {
            var lines = File.ReadLines(path);

            IdRanges = GetRanges(lines.ToArray());
            IDs = GetIDs(lines.ToArray());
        }
        public string[] GetIDs(string[] lines)
        {
            var ids = new List<string>();
            foreach(var line in lines)
            {
                if (line.Contains("-") == false && line != "")
                {
                    ids.Add(line);
                }
            }
            return ids.ToArray();

        }
        public string[] GetRanges(string[] lines)
        {
            var ranges = new List<string>();
            foreach(var line in lines)
            {
                if(line == "")
                {
                    break;
                }
                else
                {
                    ranges.Add(line);
                }
            }
            return ranges.ToArray();
           

        }
        public IdRange[] StoreIdRanges()
        {
            var idRangeList = new List<IdRange>();
            foreach (var line in IdRanges)
            {
                var range = line.Split("-");
                long rangeMin = long.Parse(range[0]);
                long rangeMax = long.Parse(range[1]);
                idRangeList.Add(new IdRange(rangeMin, rangeMax));
            }
            return idRangeList.ToArray();
        }
        public IngridientID[] StoreIngridientID()
        {
            var IngridientIdList = new List<IngridientID>();
            foreach (var line in IDs)
            {
                var temp = long.Parse(line);
                IngridientIdList.Add(new IngridientID(temp));
            }
            return IngridientIdList.ToArray();
        }

    }

}
