using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Puzzle1
{
    public class Puzzle4
    {
        private readonly string _dataPath;
        public Puzzle4(String _dataPath)
        {
            this._dataPath = _dataPath;
        }
        public long Run()
        {
            DataHandler inputData = new DataHandler(_dataPath);
            inputData.ReadData();
            JoltageFinder jolter = new JoltageFinder(inputData.getRows(), 2);
            long totalJoltage = jolter.GetTotalJoltage();
            return totalJoltage;
        }
        public long Run2()
        {
            DataHandler inputData = new DataHandler(_dataPath);
            inputData.ReadData();
            JoltageFinder jolter2 = new JoltageFinder(inputData.getRows(), 12);
            long totalJoltage12 = jolter2.GetTotalJoltMany();
            return totalJoltage12;
        }
    }
}
