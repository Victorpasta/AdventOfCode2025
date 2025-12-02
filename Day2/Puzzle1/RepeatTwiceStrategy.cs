using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Puzzle1
{
    public class RepeatTwiceStrategy : IdIsInvalidStrategy
    {
        public override bool IdIsInvalid(string id)
        {
            if (id.Length % 2 == 1)
                return false;
            var firstHalf = id.Substring(0, id.Length / 2);
            var secondHalf = id.Substring(id.Length / 2);
            return firstHalf == secondHalf;
        }

      
    }
}
