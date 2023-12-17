using System.Text.RegularExpressions;

var input = File.ReadAllLines("input.txt").ToList();

var inputLineLength = input[0].Length;


var symbols = GetSymbols(input);
foreach (var symbol in symbols)
{
    Console.WriteLine(symbol);
}

var preprocessedInput = PreprocessInput(input).ToList();
preprocessedInput.ForEach(line => Console.WriteLine(line));

Console.WriteLine($"Input line length: {inputLineLength}");

public static partial class Program
{
    public static IEnumerable<string> PreprocessInput(List<string> input)
    {
        var result = new List<string>();
        input.ForEach(line =>
        {
            result.Add(line.PadRight(1, '.'));
        });
        
        var lineLength = input[0].Length;
        var xPadding = new string('.', lineLength);
        result.Add(xPadding);
        return result.Prepend(xPadding);
    }
    public static IEnumerable<char> GetSymbols(List<string> input)
    {
        var flattenedInput = string.Join("", input);

        return new HashSet<char>(MyRegex().Replace(flattenedInput, ""));

        
    }

    [GeneratedRegex("[0-9.]")]
    private static partial Regex MyRegex();
}