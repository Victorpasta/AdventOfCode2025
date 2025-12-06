using Day1.Puzzle1;
using Day1.Puzzle2;
using Day2.Puzzle3;
using Day3.Puzzle1;
using Day4;
using Day4.Puzzle1;
using Day5;
using Day6;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void Puzzle1Test()
        {
            var puzzle1 = new Puzzle1(50, "C:\\Users\\Alexander\\Documents\\skola\\Gitrepo\\AdventOfCode2025\\Day1\\Puzzle1\\Input.txt");
            var res = puzzle1.Run();

        }
        [Fact]
        public void Puzzle2Test()
        {
            var puzzle2 = new Puzzle2(50, "C:\\Users\\Alexander\\Documents\\skola\\Gitrepo\\AdventOfCode2025\\Day1\\Puzzle1\\Input.txt");
            //var puzzle2 = new Puzzle2(50, "C:\\Users\\vicsch\\source\\personal\\AdventOfCode2025\\Day1\\TextFile1.txt");
            var res = puzzle2.Run();

        }
        [Fact]
        public void Puzzle3Test()
        {
            var puzzle3 = new Puzzle3("C:\\Users\\Alexander\\Documents\\skola\\Gitrepo\\AdventOfCode2025\\Day2\\Puzzle3\\input_day2.txt");
            var res = puzzle3.Run();
        }
        [Fact]
        public void Puzzle4Test()
        {
            //"C:\\Users\\Alexander\\Documents\\skola\\Gitrepo\\AdventOfCode2025\\Day3\\input.txt"
            var puzzle4 = new Puzzle4("C:\\Users\\Alexander\\Documents\\skola\\Gitrepo\\AdventOfCode2025\\Day3\\day3test.txt");
            var res = puzzle4.Run();
        }
        [Fact]
        public void Puzzle5Test()
        {
            //"C:\\Users\\Alexander\\Documents\\skola\\Gitrepo\\AdventOfCode2025\\Day3\\day3test.txt"
            var puzzle5 = new Puzzle4("C:\\Users\\Alexander\\Documents\\skola\\Gitrepo\\AdventOfCode2025\\Day3\\input.txt");
            var res = puzzle5.Run2();
        }
        [Fact]
        public void Puzzle6Test()
        {
            //"C:\\Users\\Alexander\\Documents\\skola\\Gitrepo\\AdventOfCode2025\\Day4\\Day4Test.txt""C:\\Users\\Alexander\\Documents\\skola\\Gitrepo\\AdventOfCode2025\\Day4\\new 6.txt"
            var puzzle6 = new RunPuzzle("C:\\Users\\Alexander\\Documents\\skola\\Gitrepo\\AdventOfCode2025\\Day4\\input.txt");

            var res = puzzle6.MultipleRuns();
        }
        [Fact]
        public void Puzzle7Test()
        {
            //"C:\\Users\\Alexander\\Documents\\skola\\Gitrepo\\AdventOfCode2025\\Day5\\Test.txt"
            var puzzle7 = new PuzzleRun("C:\\Users\\Alexander\\Documents\\skola\\Gitrepo\\AdventOfCode2025\\Day5\\input.txt");
            var res = puzzle7.Run();
        }
        [Fact]
        public void Puzzle8Test()
        {
            var puzzle8 = new PuzzleRun("C:\\Users\\Alexander\\Documents\\skola\\Gitrepo\\AdventOfCode2025\\Day5\\input.txt");
            var res = puzzle8.Run2();
        }
        [Fact]
        public void Puzzle9Test()
        {
            //"C:\\Users\\Alexander\\Documents\\skola\\Gitrepo\\AdventOfCode2025\\Day6\\Test.txt"
            var puzzle9 = new RunPuzzle2("C:\\Users\\Alexander\\Documents\\skola\\Gitrepo\\AdventOfCode2025\\Day6\\input.txt");
            var res = puzzle9.Run();
        }
        [Fact]
        public void puzzle10Test()
        {
            long res = Day6Puzzle2.Run("C:\\Users\\Alexander\\Documents\\skola\\Gitrepo\\AdventOfCode2025\\Day6\\input.txt");
        }
    }
}