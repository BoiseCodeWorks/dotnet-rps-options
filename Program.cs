using System;
using System.Collections.Generic;

namespace rps {
    class Program {
        static void Main (string[] args) {

            Option rock = new Option(){
                Name = "Rock",
                LosesTo = "Paper"
            };
            Option paper = new Option(){
                Name = "Paper",
                LosesTo = "Scissors"
            };
            Option scissors = new Option(){
                Name = "Scissors",
                LosesTo = "Rock"
            };

            Game rps = new Game () {
                Name = "Rock, Paper, Scissors",
                Description = "Make a choice win lose or draw",
                Rules = "Paper beats Rock, Rock beats Scissors, Scissors beats Paper", 
                Options = new List<Option>(){
                    rock,
                    paper,
                    scissors
                }
            };

            Game rpsls = new Game () {
                Name = "Rock, Paper, Scissors, lizard, Spock",
                Description = "Make a choice win lose or draw",
                Rules = "Paper beats Rock, paper disproves Spock, Rock beats Scissors, Scissors beats Paper"
            };
            
            System.Console.WriteLine("Welcome Lets play a game,");
            rps.PrintGameOverview();
            rps.StartGame();

            Console.ReadLine();
        }
    }
}