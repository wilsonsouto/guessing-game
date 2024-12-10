namespace GuessingGame;

public class Game
{
    public int Guess { get; set; }
    public int Answer { get; set; }
    public bool GameOver { get; set; }
    public Random Random { get; set; } = new Random();
}
