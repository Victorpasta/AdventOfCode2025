using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public class IngridientID
    {
        public IngridientID(long id)
        {
            Id = id;
        }
        public bool IsFresh { get; set; }
        public long Id { get; set; }
    }
}
