namespace Day1;

public class PartOne(IEnumerable<string> input)
{
    private int _runningTotal = 0;
    
    public int Solve()
    {
        input.ToList().ForEach(line =>
        {
            var numbers = line
                .ToCharArray()
                .Select(c => int.TryParse(c.ToString(), out var number) ? number : -1)
                .Where(n => n != -1)
                .ToList();
            
            _runningTotal += (numbers.First() * 10) + numbers.Last();
        });
        return _runningTotal;
    }
}