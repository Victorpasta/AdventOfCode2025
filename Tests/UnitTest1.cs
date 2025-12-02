using Day1.Puzzle1;
using Day1.Puzzle2;
using Day2.Puzzle3;


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

    }
}