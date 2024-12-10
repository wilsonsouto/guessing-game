namespace GuessingGame;
internal class Program
{
  private static void Main(string[] args)
  {
    Game player = new();

    player.Answer = player.Random.Next(1, 11);

    while (!player.GameOver)
    {
      Console.WriteLine("\nPlease enter your guess, pick a number from 1 to 10");
      var userAnswer = Console.ReadLine();

      if (!string.IsNullOrEmpty(userAnswer))
      {
        player.Guess = int.Parse(userAnswer);

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
          Console.WriteLine($"You guessed it right! the number is {player.Answer}");
          player.GameOver = true;
        }

      }
    }
  }
}
