namespace Day2;

public class PartOne(List<string> input)
{
    private int _runningTotal = 0;
    const int MAX_RED = 12;
    const int MAX_GREEN = 13;
    const int MAX_BLUE = 14;
    public int Solve()
    {
        input.ToList().ForEach(input =>
        {
            var gameId = int.Parse(input.Split(':')[0].Split(' ')[1]);
            var rounds = input.Split(':')[1].Split(';').Select(x => x.Trim()).ToList();
            var reds = new List<int>();
            var greens = new List<int>();
            var blues = new List<int>();

            rounds.ForEach(round =>
            {
                var redCubes = CubeCount("red", round);
                var greenCubes = CubeCount("green", round);
                var blueCubes = CubeCount("blue", round);

                reds.Add(redCubes);
                greens.Add(greenCubes);
                blues.Add(blueCubes);
            });

            var possible = reds.Max() <= MAX_RED && greens.Max() <= MAX_GREEN && blues.Max() <= MAX_BLUE;

            if (possible)
            {
                _runningTotal += gameId;
            }

        });

        return _runningTotal;
    }

    private static int CubeCount(string CubeColour, string Round) {
    var cubeCount = Round.Split(',').Where(x => x.Contains(CubeColour)).Select(x => int.Parse(x.Trim().Split(' ')[0])).FirstOrDefault();
    return cubeCount;

}
}
