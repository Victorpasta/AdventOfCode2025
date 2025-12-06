using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public class RunPuzzle2
    {
        public string Path;
        public RunPuzzle2(string path)
        {
            Path = path;
        } 
        public long Run()
        {
            var readData = new ReadData1(Path);
            long a = readData.sumAllRows();
            return a;
        }
            
    }
}
