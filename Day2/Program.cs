using Day2;

var input = File.ReadAllLines("input.txt").ToList();

var partOneTotal = new PartOne(input).Solve();

Console.WriteLine($"Total: {partOneTotal}");