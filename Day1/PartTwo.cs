namespace Day1;

public class PartTwo(IEnumerable<string> input)
{
   private int _runningTotal = 0;

    public int Solve()
    {
        
        input.ToList().ForEach(line =>
        {
            var numbers = ReplaceDigitWordWithDigit(line)
                    
                
                .ToCharArray()
                .Select(c => int.TryParse(c.ToString(), out var number) ? number : -1)
                .Where(n => n != -1)
                .ToList();

            _runningTotal += (numbers.First() * 10) + numbers.Last();
        });

        return _runningTotal;
    }
    
    private static string ReplaceDigitWordWithDigit (string input)
    {
        
        var one = input.Replace("one", "o1e");
        var two = one.Replace("two", "t2o");
        var three = two.Replace("three", "t3e");
        var four = three.Replace("four", "f4r");
        var five = four.Replace("five", "f5e");
        var six = five.Replace("six", "s6x");
        var seven = six.Replace("seven", "s7n");
        var eight = seven.Replace("eight", "e8t");
        var nine = eight.Replace("nine", "n9e");
        
        return nine;
    }
    
    }