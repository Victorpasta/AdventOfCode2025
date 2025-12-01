using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Puzzle1
{
    public class Puzzle1 : Day1Puzzle
    {
        public Puzzle1(int start, string path):base(start, path)
        {

        }
        //Fusk! total används inte

        public override int Run() 
        {
            int nbrOfZeroes = 0;
            var lines = File.ReadLines(_inputPath);
            foreach (var line in lines)
            {
                bool isIncreasing = line.StartsWith("R");
                var total = CalculateTotal(line, isIncreasing, _current);
                _current = total % 100;
                if (_current == 0)
                    nbrOfZeroes++;
            }
            return nbrOfZeroes;
        }

        
    }
}
