var input = File.ReadAllLines("input.txt");


var partOneTotal = new Day1.PartOne(input).Solve();
var partTwoTotal = new Day1.PartTwo(input).Solve();

Console.WriteLine($"Part One Total: {partOneTotal}");
Console.WriteLine($"Part Two Total: {partTwoTotal}");




    
    

