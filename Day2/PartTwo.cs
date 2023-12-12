namespace Day2;

public class PartTwo(List<Game> games)
{
    private int _runningTotal = 0;

    public int Solve()
    {
        games.ForEach(game =>
        {
            if (game.Rounds == null) return;
            var maxRed = game.Rounds.Max(x => x.RedCubes);
            var maxGreen = game.Rounds.Max(x => x.GreenCubes);
            var maxBlue = game.Rounds.Max(x => x.BlueCubes);
                
            var totalPower = maxRed * maxGreen * maxBlue;
                
            _runningTotal += totalPower;
        });
        
        return _runningTotal;
    }
}