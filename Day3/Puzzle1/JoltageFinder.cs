using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Puzzle1
{
    public class JoltageFinder
    {
   
        protected List<List<string>> _dataArray;
        private int _NbrOfBatteries;


        public JoltageFinder(List<List<string>> dataArray, int batteries)
        {
            this._dataArray = dataArray;
            _NbrOfBatteries = batteries;
        }
        public long GetTotalJoltage()
        {
            long totalJoltage = 0;
            

            for  (int i = 0; i < _dataArray.Count; i++)
            {
                long currentHigh = HighestDigit(i, out int index, _dataArray[i]);
                if (index == (_dataArray[i].Count) - 1)
                {
                    List<string> searchSpaceEnd = _dataArray[i][..(_dataArray[i].Count - 1)];

                    long secondHighest = HighestDigit(i, out _, searchSpaceEnd);
                    
                    string tempJoltageString = secondHighest.ToString() + currentHigh.ToString();
                    
                    totalJoltage += long.Parse(tempJoltageString);
                }
                else if (index == 0)
                {
                    List<string> searchSpaceStart = _dataArray[i][1..];
                    
                    long secondHighest = HighestDigit(i, out _, searchSpaceStart);
                    
                    string tempJoltageString = currentHigh.ToString() + secondHighest.ToString();
                    
                    totalJoltage += long.Parse(tempJoltageString);

                }

                else
                {
                    List<string> searchSpace = _dataArray[i][((index) + 1)..];
                    
                    long secondCurrentHigh = HighestDigit(i, out _ ,searchSpace);
                    
                    string tempJoltageString = currentHigh.ToString() + secondCurrentHigh.ToString();
                    
                    totalJoltage += long.Parse(tempJoltageString);
                }
            }
            return totalJoltage;
        }
        public long HighestDigit(int i, out int index, List<string> searchSpace)
        {
            index = 0;
            int currentHigh = 0;
            for (int j = 0; j < searchSpace.Count; j++)
            {
                if (currentHigh < int.Parse(searchSpace[j]))
                {
                    currentHigh = int.Parse(searchSpace[j]);
                    index = j;
                }
            }
            return currentHigh;
        }
        public long GetTotalJoltMany()
        {
            long totalJoltage = 0;
            
            for (int i = 0; i < _dataArray.Count; i++)
            {
                var tempJoltString = "";
                var startIndex = 0;
                var lengthNextSearchSpace = _dataArray[i].Count - _NbrOfBatteries + 1;
                List<string> nextSearchSpace = _dataArray[i][0..lengthNextSearchSpace];
                for (int j = 0; j < _NbrOfBatteries; j++)
                {
                    string digit = HighestDigit(i, out int index, nextSearchSpace).ToString();
                    startIndex = index + startIndex + 1;
                    int endIndex = _dataArray[i].Count - (_NbrOfBatteries - j - 1);
                    if (endIndex > _dataArray[i].Count)
                    {
                        nextSearchSpace = _dataArray[i][(startIndex)..];
                    }
                    else if (endIndex >= _dataArray[i].Count){
                        nextSearchSpace = _dataArray[i][startIndex..];
                    }
                    else
                    {
                        nextSearchSpace = _dataArray[i][startIndex..(endIndex + 1)];
                    }
                    tempJoltString += digit;

                }
                totalJoltage += long.Parse(tempJoltString);
            }
            return totalJoltage;

        }





        /*
        public int JoltageFinder()
        {
            int currentHigh = 0;
            int currentHighIndex = 0;
            int currentSecondHighest = 0;

            int secondHighest = 0;
            int secondHighestIndex = 0;

            string tempJoltageString = "";
            int totalJoltage = 0;

            for (int i = 0; i < _dataArray.Count; i++)
            {
                for (int j = 0; j < _dataArray[i].Count; j++)
                {
                    if (currentHigh < int.Parse(_dataArray[i][j]))
                    {
                        currentHigh = int.Parse(_dataArray[i][j]);
                        currentHighIndex = j;
                    }
                }
                for (int j = 0; j < _dataArray[i].Count; j++)
                {
                    if (j != currentHighIndex && secondHighest < int.Parse(_dataArray[i][j]))
                    {
                        secondHighest = int.Parse(_dataArray[i][j]);
                        secondHighestIndex = j;
                    }

                }
                if (currentHighIndex > secondHighestIndex && currentHighIndex == _dataArray[i].Count - 1)
                {   
                    tempJoltageString = secondHighest.ToString() + currentHigh.ToString();
                }
                else if ( currentHighIndex > secondHighestIndex)
                {
                    secondHighest = 0;
                    for (int j = currentHighIndex + 1; j < _dataArray[i].Count; j++)
                    {
                        if (secondHighest < int.Parse(_dataArray[i][j]))
                        {
                            secondHighest = int.Parse(_dataArray[i][j]);
                            tempJoltageString = currentHigh.ToString() + secondHighest.ToString();
                        }
                        
                    }
                }
                else
                {
                    tempJoltageString = currentHigh.ToString() + secondHighest.ToString();
                }
                secondHighest = 0;
                currentHigh = 0;
                totalJoltage += int.Parse(tempJoltageString);
            }
            return totalJoltage;
        }
        */
    }
}
