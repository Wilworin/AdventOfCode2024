using System.Threading;

class Day1
{
    private string _fileName = "Day1\\input.txt";
    private string[] input;
    Helper _helper = new Helper();
    List<int> left = new List<int>();
    List<int> right = new List<int>();
    
    public Day1()
    {
        input = _helper.ReadFileIntoStringArray(_fileName);
        foreach (var row in input)
        {
            var split = row.Split(' ');
            left.Add(int.Parse(split[0]));
            right.Add(int.Parse(split[3]));
        }
    }
    
    public void Challenge1()
    {
        int sum = 0;

        left.Sort();
        right.Sort();
        for (int i = 0; i < left.Count; i++)
        {
            sum += Math.Abs(left[i] - right[i]);
        }

        Console.WriteLine("Day1. Challenge 1: " + sum); // 1666427
    }

    public void Challenge2()
    {
        long sum = 0;

        foreach (var number in left)
        {
            sum += number * right.FindAll(x => x == number).Count();
        }
        Console.WriteLine("Day1. Challenge 2: " + sum);  // 24316233
    }
}
