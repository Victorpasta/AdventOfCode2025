using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day6
{
    public class Day6Puzzle2
    {
        public static long Run(string path)
        {
            long tot = 0;
            var lines = File.ReadLines(path).ToArray();

            var nums1 = GetHumanNumbers(lines[0]);
            var nums2 = GetHumanNumbers(lines[1]);
            var nums3 = GetHumanNumbers(lines[2]);
            var nums4 = GetHumanNumbers(lines[3]);
           
            var operators = GetOperators(lines[4]);
            for (int i = 0; i < nums1.Count; i++)
            {
                var cephalopodNumbers = ConvertToCephalopod(nums1[i], nums2[i], nums3[i], nums4[i]);
                var operation = operators[i];
                long numberToAdd = operation == "*" ? 1 : 0;
                foreach (var cephalopodNumber in cephalopodNumbers)
                {
                    if (operation == "*")
                        numberToAdd = cephalopodNumber * numberToAdd;

                    if (operation == "+")
                        numberToAdd = cephalopodNumber + numberToAdd;
                }
                tot += numberToAdd;
            }
            return tot;
        }
        public static List<string> GetHumanNumbers(string line)
        {
            return Regex.Matches(line, @"\s*\d+")
                .Select(m => m.Value)
                .ToList();
        }
        public static List<long> ConvertToCephalopod(string humanNumber1, string humanNumber2, string humanNumber3, string humanNumber4)
        {
            List<long> result = [];
            int i = 0;
            while (true)
            {
                var digit1 = GetDigit(humanNumber1, i);
                var digit2 = GetDigit(humanNumber2, i);
                var digit3 = GetDigit(humanNumber3, i);
                var digit4 = GetDigit(humanNumber4, i);
                if (digit1 == "" && digit2 == "" && digit3 == "" && digit4 == "")
                    break;
                if(long.TryParse(digit1 + digit2 + digit3 + digit4, out long cephalopodNum))
                    result.Add(cephalopodNum);
                i++;

            }
            return result;
        }
        public static string GetDigit(string s, int index)
        {
            if (index >= s.Length)
                return "";
            return s[index].ToString();
        }
        public static List<string> GetOperators(string line)
        {
            return Regex.Matches(line, @"[+*]")
                   .Select(m => m.Value)
                   .ToList();
        }
    }
}
