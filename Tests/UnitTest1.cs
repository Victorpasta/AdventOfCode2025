using Day1.Puzzle1;
using Day1.Puzzle2;
using Day2.Puzzle1;
using Day2.Puzzle2;

namespace Tests
{
    public class TestsDay1
    {
        [Fact]
        public void Puzzle1Test()
        {
            var puzzle1 = new Day1.Puzzle1.Puzzle1(50, "C:\\Users\\vicsch\\source\\personal\\AdventOfCode2025\\Day1\\Puzzle1\\Input.txt");
            var res = puzzle1.Run();
            
        }
        [Fact]
        public void Puzzle2Test()
        {
            var puzzle2 = new Puzzle2(50, "C:\\Users\\vicsch\\source\\personal\\AdventOfCode2025\\Day1\\Puzzle1\\Input.txt");
            //var puzzle2 = new Puzzle2(50, "C:\\Users\\vicsch\\source\\personal\\AdventOfCode2025\\Day1\\TextFile1.txt");
            var res = puzzle2.Run();

        }
    }
    public class TestsDay2
    {
        [Fact]
        public void Puzzle1Test()
        {
            var res = Day2.Puzzle1.Puzzle3Victor.Run("C:\\Users\\vicsch\\source\\personal\\AdventOfCode2025\\Day2\\TestInput.txt", new RepeatTwiceStrategy());
            Assert.Equal(1227775554, res);
        }
        [Fact]
        public void Puzzle1Run()
        {
            var res = Day2.Puzzle1.Puzzle3Victor.Run("C:\\Users\\vicsch\\source\\personal\\AdventOfCode2025\\Day2\\InputVictor.txt", new RepeatTwiceStrategy());

        }
        [Fact]
        public void Puzzle2Test()
        {
            var res = Day2.Puzzle1.Puzzle3Victor.Run("C:\\Users\\vicsch\\source\\personal\\AdventOfCode2025\\Day2\\TestInput.txt", new RepeatAnyStrategy());
            Assert.Equal(4174379265, res);

        }
        [Fact]
        public void Puzzle2Run()
        {
            var res = Day2.Puzzle1.Puzzle3Victor.Run("C:\\Users\\vicsch\\source\\personal\\AdventOfCode2025\\Day2\\InputVictor.txt", new RepeatAnyStrategy());

        }
        [Fact]
        public void Puzzle2RunSlotte()
        {
            var res = Day2.Puzzle1.Puzzle3Victor.Run("C:\\Users\\vicsch\\source\\personal\\AdventOfCode2025\\Day2\\InputSlotte.txt", new RepeatAnyStrategy());

        }
    }
    public class TestsDay3
    {
        [Fact]
        public void Puzzle1Test()
        {
            var res = Day3.Puzzle1.Day3Puzzle1.Run("C:\\Users\\vicsch\\source\\personal\\AdventOfCode2025\\Day3\\TestInput.txt",2);
            Assert.Equal(357, res);
        }
        [Fact]
        public void Puzzle1Run()
        {
            var res = Day3.Puzzle1.Day3Puzzle1.Run("C:\\Users\\vicsch\\source\\personal\\AdventOfCode2025\\Day3\\InputVictor.txt", 2);
            Assert.Equal(17100, res);
        }
        [Fact]
        public void Puzzle2Test()
        {
            var res = Day3.Puzzle1.Day3Puzzle1.Run("C:\\Users\\vicsch\\source\\personal\\AdventOfCode2025\\Day3\\TestInput.txt", 12);
            Assert.Equal(3121910778619, res);
        }
        [Fact]
        public void Puzzle2Run()
        {
            var res = Day3.Puzzle1.Day3Puzzle1.Run("C:\\Users\\vicsch\\source\\personal\\AdventOfCode2025\\Day3\\InputVictor.txt", 12);
            Assert.Equal(17100, res);
        }
    }
    }