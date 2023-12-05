var input = File.ReadAllLines("input.txt");


var runningTotal = 0;

input.ToList().ForEach(line =>
{

    var numbers = line
        .ToCharArray()
        .Select(c => int.TryParse(c.ToString(), out var number) ? number : -1)
        .Where(n => n != -1);
    
    var first = numbers.First();
    var last = numbers.Last();

    var combinedDigits = int.Parse(first.ToString() + last.ToString());
    
    runningTotal += combinedDigits;

});

Console.WriteLine($"Total: {runningTotal}");
Console.ReadKey();




    
    

