using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Puzzle1
{
    public class DataHandler
    {
        private readonly string _inputPath;
        private string files;
        private List<List<string>> rows;
        

       

        public DataHandler(string path)
        {
            this._inputPath = path;
        }

        public void ReadData()
        {
            
            this.rows = new List<List<string>>();
            var file = File.ReadAllText(_inputPath);
            string[] tempLines = file.Split(new[] { "\r\n", "\n", "\r" }, StringSplitOptions.None);

            for (int i = 0; i < tempLines.Length; i++)
            {
                string line = tempLines[i];
                var lines = new List<string>();

                for (int j = 0; j < tempLines[i].Length; j++)
                {
                    lines.Add(line[j].ToString());
                }
                rows.Add(lines);
            }
        }
        public List<List<string>> getRows()
        {
            return rows;
        }

    }
}
