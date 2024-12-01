/******************************
 * Advent of Code  Year 2024  *
 ******************************/

new Day1().Challenge1();
new Day1().Challenge2();
// new Day2().Challenge1();
// new Day2().Challenge2();
// new Day3().Challenge1();
// new Day3().Challenge2();
// new Day4().Challenge1();
// new Day4().Challenge2();
// new Day5().Challenge1();
// new Day5().Challenge2();
// new Day6().Challenge1();
// new Day6().Challenge2();
// new Day7().Challenge1();
// new Day7().Challenge2();
// new Day8().Challenge1();
// new Day8().Challenge2();
// new Day9().Challenge1();
// new Day9().Challenge2();
// new Day10().Challenge1();
// new Day10().Challenge2();
// new Day11().Challenge1();
// new Day11().Challenge2();
// new Day12().Challenge1();
// new Day12().Challenge2();
// new Day13().Challenge1();
// new Day13().Challenge2();

//Console.WriteLine(long.Parse(string.Concat(new int[] {0,1,2,3,4,5,6,7,8,9})).ToString("<000> 000-0000")); 
//string fileName = "Day8\\input.txt";
//var input = Helper.ReadFileInto2DIntArray(fileName);
//Console.WriteLine(input);


class Day
{
    private const string _fileName = "Day\\input.txt";
    Helper helper = new Helper();

    public Day()
    {
        string[] input = helper.ReadFileIntoStringArray(_fileName);
    }

    public void Challenge1()
    {
        Console.WriteLine("Day . Challenge 1: ");
    }

    public void Challenge2()
    {
        Console.WriteLine("Day . Challenge 2: ");
    }
}