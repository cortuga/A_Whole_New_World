using System;

namespace A_Whole_New_World
{
  class Program
  {
    static void Main(string[] args)
    {
      var min = 1m;
      var max = 100m;
      var comGuess = false;

      while (!comGuess)
      {
        var guess = Math.Floor((min + max) / 2);

        Console.WriteLine($"Is this your number? {guess}");

        var userResponse = Console.ReadLine();
        if (userResponse == "yes")
        {
          comGuess = true;
        }
        else if (userResponse == "lower")
        {
          max = guess;

        }
        else if (userResponse == "higher")
        {
          min = guess;
        }

      }
    }
  }

}

