class Helper
{
    public string[] ReadFileIntoStringArray(string fileName)
    {
        string[] result = File.ReadAllLines("..\\..\\..\\" + fileName);
        return result;
    }

    public string ReadFileIntoString(string fileName)
    {
        string[] result = File.ReadAllLines("..\\..\\..\\" + fileName);
        return result[0];
    }

    public List<string> ReadFileIntoStringList(string fileName)
    {
        List<string> result = new();
        string[] inData = File.ReadAllLines("..\\..\\..\\" + fileName);
        foreach (string s in inData)
        {
            result.Add(s);
        }
        return result;
    }

    public List<int> ReadFileIntoIntList(string fileName)
    {
        List<int> result = new();
        string[] fileInput = File.ReadAllLines("..\\..\\..\\" + fileName);
        int number = 0;
        foreach (string line in fileInput)
        {
            if (int.TryParse(line, out number))
            {
                result.Add(number);
            }
        }
        return result;
    }

    public int[] ReadFileIntoIntArray(string fileName)
    {
        List<int> result = new();
        string[] fileInput = File.ReadAllLines("..\\..\\..\\" + fileName);
        int number = 0;
        foreach (string line in fileInput)
        {
            if (int.TryParse(line, out number))
            {
                result.Add(number);
            }
        }
        return result.ToArray();
    }

    public int[,] ReadFileInto2DIntArray(string fileName)
    {
        string[] fileInput = File.ReadAllLines("..\\..\\..\\" + fileName);
        var xMax = fileInput[0].Length;
        var yMax = fileInput.Length;

        var result = new int[xMax, yMax];
        for (int y = 0; y < yMax; y++)
        {
            for (int x = 0; x < xMax; x++)
            {
                var t = fileInput[y][x];
                //result[x, y] = int.Parse(t);
            }
        }
        return result;
    }

    public int ConvertBinaryStringToDecimalInt(string binary)
    {
        return Convert.ToInt32(binary, 2);
    }

    public void ConvertStringArrayIntoIntArray(string[] input, int[,] inData)
    {
        for (int row = 0; row < input.Length; row++)
        {
            for (int col = 0; col < input[0].Length; col++)
            {
                inData[col, row] = (int)input[row].ElementAt(col) - 48;
            }
        }
    }
    
    public List<int> ParseStringsToInts (string[] strings)
    {
        var output = new List<int>();
        for (int i = 1; i < strings.Length; i++)
        {
            if (!string.IsNullOrEmpty(strings[i]))
                output.Add(int.Parse(strings[i]));
        }
        return output;
    }

    public long ParseStringsToLongs(string[] strings)
    {
        var output = "";
        for (int i = 1; i < strings.Length; i++)
        {
            if (!string.IsNullOrEmpty(strings[i]))
                output += strings[i];
        }
        return long.Parse(output);
    }
}