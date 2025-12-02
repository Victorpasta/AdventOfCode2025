using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day2.Puzzle2
{
    public class RepeatAnyStrategy : IdIsInvalidStrategy
    {
        public override bool IdIsInvalid(string id)
        {
            var pattern = @"^(.+?)\1+$";
            var match = Regex.Match(id, pattern);
            return match.Success;
        }
    }
}
