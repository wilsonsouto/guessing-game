namespace GuessingGame;
internal class Program
{
  private static void Main(string[] args)
  {
    Game player = new();

    player.Answer = player.Random.Next(1, 11);

    while (!player.GameOver)
    {
      player.GetUserInput();

      if (player.Guess < player.Answer)
      {
        Console.WriteLine("Your guess is to below");
      }
      else if (player.Guess > player.Answer)
      {
        Console.WriteLine("Your guess is to high");
      }
      else
      {
        Console.WriteLine($"You guessed it the number is {player.Answer}");
        player.GameOver = true;
      }
    }
  }
}
