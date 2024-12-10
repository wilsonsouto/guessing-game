namespace GuessingGame;

public class Game
{
    public int Guess { get; set; }
    public int Answer { get; set; }
    public bool GameOver { get; set; }
    public Random Random { get; set; } = new Random();
    public void GetUserInput()
    {
        Console.WriteLine("Please enter your guess, pick a number from 1 to 10");
        var input = Console.ReadLine();
        
        if (!string.IsNullOrEmpty(input))
        {
            Guess = int.Parse(input);
        }
    }
}
