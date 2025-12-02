using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Day2.Puzzle3
{
    public class Puzzle3
    {
        private readonly string path;
        public Puzzle3(string path)
        {
            this.path = path;
        }
        public long Run()
        {
         
            int start = 0;
            long total = 0;
            string temp = "";
            using StreamReader reader = new StreamReader(path);
            string line = reader.ReadToEnd();

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == ',')
                {
                    temp = line[start..i];
                    total += CalculateTotal(temp);
                    start = i + 1;
                }
            }
            return total;
           
        }
        public long CalculateTotal(string line)
        {
            long id1 = 0;
            long id2 = 0;
            long total = 0;
            string stringId = "";
           
          
            // Dela upp id.
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '-')
                {
                    id1 = long.Parse(line[..i]);
                    id2 = long.Parse(line[(i+1)..]);
                   
                }

            }
            if (id1 < id2)
            {
                for (long i = id1; i <= id2; i++)
                {
                    stringId = Convert.ToString(i);

                    // total += GetNumbIfInvalid(stringId, i);
                    total += GetNumbReapeatingIfInvalid(stringId, i);

                }
            }
            return total;
        }
        private long GetNumbIfInvalid(string stringId, long i)
        {
            if (stringId.Length % 2 == 0)
            {
                var comp1 = stringId[..(stringId.Length / 2)];
                var comp2 = stringId[(stringId.Length / 2)..];
                if (comp1 == comp2)
                {
                    return i;
                }
            }
            return 0;
        }
        public long GetNumbReapeatingIfInvalid(string stringId, long i)
        {
            var pattern = @"^(.+?)\1+$";
            var match = Regex.Match(stringId, pattern);
            if (match.Success == true)
                return i;
            return 0;
        }

    }
}
