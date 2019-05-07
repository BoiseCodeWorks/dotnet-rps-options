using System;
using System.Collections.Generic;

namespace rps {
  class Game {
    public string Name { get; set; }
    public string Description { get; set; }
    public string Rules { get; set; }

    public int Losses { get; set; } = 0;
    public int Wins { get; set; } = 0;

    public List<Option> Options { get; set; }

    public void PrintGameOverview () {
      System.Console.WriteLine ("===================");
      System.Console.WriteLine ("Name:");
      System.Console.WriteLine (Name);
      System.Console.WriteLine ("===================");
      System.Console.WriteLine ("Description:");
      System.Console.WriteLine (Description);
      System.Console.WriteLine ("===================");
      System.Console.WriteLine ("Rules:");
      System.Console.WriteLine (Rules);
    }

    public void StartGame () {
      System.Console.WriteLine ($"STARTING: {Name}");
      int optionNumber = 1;
      foreach (var o in Options) {
        System.Console.WriteLine ($"{optionNumber} - {o.Name}");
        optionNumber += 1;
      }
      int choicePosition;

      string playerChoice = System.Console.ReadLine ();

      if (!int.TryParse (playerChoice, out choicePosition) ||
        choicePosition <= 0 ||
        choicePosition > Options.Count + 1) {
        StartGame ();
      }

      Option validOption = Options[choicePosition];

      Random rand = new Random ();
      int compChoicePosition = rand.Next (0, Options.Count);
      Option compChoice = Options[compChoicePosition];

      if (compChoice.LosesTo == validOption.Name) {
        Wins++;
      } else {
        Losses++;
      }
      System.Console.WriteLine ($"Wins: {Wins}, Losses: {Losses}");
    }

  }
}