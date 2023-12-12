using Day2;

var input = File.ReadAllLines("input.txt").ToList();

var partOne = new PartOne(input, []);
var partOneTotal = partOne.Solve();
var partTwoTotal = new PartTwo(partOne.Games).Solve();

Console.WriteLine($"Part one total: {partOneTotal}");
Console.WriteLine($"Part two total: {partTwoTotal}");