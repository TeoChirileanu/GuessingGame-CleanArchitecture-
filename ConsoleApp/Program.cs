using System;
using Adapters;
using BusinessRules;
using BusinessRules.Properties;

namespace ConsoleApp {
    internal class Program {
        private static void Main() {
            IGame game = new Game {
                Messenger = new ConsoleMessenger(),
                CorrectNumber = new Random().Next(0, 100)
            };

            var userHasGuessedTheCorrectNumber = false;
            do {
                var guessedNumber = GetNumberFromKeyboard();
                game.Check(guessedNumber);
                if (guessedNumber == game.CorrectNumber)
                    userHasGuessedTheCorrectNumber = true;
            } while (!userHasGuessedTheCorrectNumber);
        }

        private static int GetNumberFromKeyboard() {
            bool parsedSuccessfully;
            int number;
            do {
                Console.WriteLine(Resources.AskForANumber);
                var input = Console.ReadLine();
                parsedSuccessfully = int.TryParse(input, out number);
            } while (!parsedSuccessfully);

            return number;
        }
    }
}