namespace Day2;

public class PartOne
{
    private int _runningTotal;
    const int MAX_RED = 12;
    const int MAX_GREEN = 13;
    const int MAX_BLUE = 14;
    public List<Game> Games { get; set; }
    
    public PartOne(IEnumerable<string> input, List<Game> games)
    {
        Games = games;


        input.ToList().ForEach(s =>
        {
            var game = new Game
            {
                GameId = int.Parse(s.Split(':')[0].Split(' ')[1]),
                Rounds = s.Split(':')[1].Split(';').Select(x => x.Trim()).Select(round =>
                {
                    var redCubes = CubeCount("red", round);
                    var greenCubes = CubeCount("green", round);
                    var blueCubes = CubeCount("blue", round);

                    return new Round
                    {
                        RedCubes = redCubes,
                        GreenCubes = greenCubes,
                        BlueCubes = blueCubes
                    };
                }).ToList()
            };
            Games.Add(game);
        });
    }

    
    public int Solve()
    {
        Games.ForEach(game =>
        {
            var possible = game.Rounds.Max(x => x.RedCubes) <= MAX_RED && game.Rounds.Max(x => x.GreenCubes) <= MAX_GREEN && game.Rounds.Max(x => x.BlueCubes) <= MAX_BLUE;

            if (possible)
            {
                _runningTotal += game.GameId;
            }
        });
        
        return _runningTotal;
        
        
    }

    private static int CubeCount(string cubeColour, string round) {
    var cubeCount = round.Split(',').Where(x => x.Contains(cubeColour)).Select(x => int.Parse(x.Trim().Split(' ')[0])).FirstOrDefault();
    return cubeCount;

}
}
