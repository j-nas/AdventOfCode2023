namespace Day2;

public class Game
{
    public int GameId { get; set; }
    public List<Round>? Rounds { get; set; }
}

public class Round
{
    public int RedCubes { get; set; }
    public int GreenCubes { get; set; }
    public int BlueCubes { get; set; }
}